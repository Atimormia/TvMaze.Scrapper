CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

CREATE TABLE "Shows" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Shows" PRIMARY KEY AUTOINCREMENT,
    "Name" TEXT
);

CREATE TABLE "Casts" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Casts" PRIMARY KEY AUTOINCREMENT,
    "BirthDay" TEXT,
    "Name" TEXT,
    "ShowId" INTEGER,
    CONSTRAINT "FK_Casts_Shows_ShowId" FOREIGN KEY ("ShowId") REFERENCES "Shows" ("Id") ON DELETE RESTRICT
);

CREATE INDEX "IX_Casts_ShowId" ON "Casts" ("ShowId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20180911162651_InitialCreate', '1.1.2');

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20180911163923_RemoveField', '1.1.2');

