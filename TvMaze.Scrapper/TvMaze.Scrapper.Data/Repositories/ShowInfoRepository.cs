using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public async Task AddOrUpdate(ShowDto show)
        {
            if (show == null) await Task.FromResult(0);

            _context.Shows.Add(_mapper.Map<Show>(show));
            await _context.SaveChangesAsync();
        }

        public async Task AddOrUpdate(IEnumerable<ShowDto> shows)
        {
            if (shows == null || !shows.Any()) await Task.FromResult(0);

            foreach (var show in shows)
            {
                await AddOrUpdate(show);
            }
        }

        public async Task<IEnumerable<ShowDto>> GetAll()
        {
            return await _context.Shows.Include(x => x.Casts).Select(x => _mapper.Map<ShowDto>(x)).ToArrayAsync();
        }

        public async Task<ShowDto> GetById(int id)
        {
            return await _context.Shows.Include(x => x.Casts).Select(x => _mapper.Map<ShowDto>(x))
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
