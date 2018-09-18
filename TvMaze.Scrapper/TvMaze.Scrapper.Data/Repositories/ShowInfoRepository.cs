using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TvMaze.Scrapper.Data.Contracts.DTOs;
using TvMaze.Scrapper.Data.Contracts.Repositories;
using TvMaze.Scrapper.Data.Entities;

namespace TvMaze.Scrapper.Data.Repositories
{
    public class ShowInfoRepository : IShowInfoRepository
    {
        private readonly ScrapperDbContext _context;
        private readonly IMapper _mapper;

        public ShowInfoRepository(ScrapperDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

            if (!_context.Shows.Any())
            {
                _context.Shows.Add(new Show() { Id = 1, Name = "Item1" });
                _context.SaveChanges();
            }
        }

        public void AddOrUpdate(ShowDto show)
        {
            if (show == null) return;

            _context.Shows.Add(_mapper.Map<Show>(show));
            _context.SaveChanges();
        }

        public void AddOrUpdate(IEnumerable<ShowDto> shows)
        {
            if (shows == null || !shows.Any()) return;

            foreach (var show in shows)
            {
                AddOrUpdate(show);
            }
            _context.SaveChanges();
        }

        public IEnumerable<ShowDto> GetAll()
        {
            return _context.Shows.Include(x => x.Casts).ToList().Select(x => _mapper.Map<ShowDto>(x));
        }

        public ShowDto GetById(int id)
        {
            return _mapper.Map<ShowDto>(_context.Shows.Include(x => x.Casts).ToList().Find(x => x.Id == id));
        }
    }
}
