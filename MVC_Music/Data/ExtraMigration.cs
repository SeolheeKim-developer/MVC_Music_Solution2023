using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Music.Data
{
    public static class ExtraMigration
    {
        public static void Steps(MigrationBuilder migrationBuilder)
        {
            //Triggers for Musician
            migrationBuilder.Sql(
                @"
                    CREATE TRIGGER SetMusicianTimestampOnUpdate
                    AFTER UPDATE ON Musicians
                    BEGIN
                        UPDATE Musicians
                        SET RowVersion = randomblob(8)
                        WHERE rowid = NEW.rowid;
                    END
                ");
            migrationBuilder.Sql(
                @"
                    CREATE TRIGGER SetMusicianTimestampOnInsert
                    AFTER INSERT ON Musicians
                    BEGIN
                        UPDATE Musicians
                        SET RowVersion = randomblob(8)
                        WHERE rowid = NEW.rowid;
                    END
                ");
            //Triggers for Instrument
            migrationBuilder.Sql(
                @"
                    CREATE TRIGGER SetInstrumentTimestampOnUpdate
                    AFTER UPDATE ON Instruments
                    BEGIN
                        UPDATE Instruments
                        SET RowVersion = randomblob(8)
                        WHERE rowid = NEW.rowid;
                    END
                ");
            migrationBuilder.Sql(
                @"
                    CREATE TRIGGER SetInstrumentTimestampOnInsert
                    AFTER INSERT ON Instruments
                    BEGIN
                        UPDATE Instruments
                        SET RowVersion = randomblob(8)
                        WHERE rowid = NEW.rowid;
                    END
                ");
            //Triggers for Album
            migrationBuilder.Sql(
                @"
                    CREATE TRIGGER SetAlbumTimestampOnUpdate
                    AFTER UPDATE ON Albums
                    BEGIN
                        UPDATE Albums
                        SET RowVersion = randomblob(8)
                        WHERE rowid = NEW.rowid;
                    END
                ");
            migrationBuilder.Sql(
                @"
                    CREATE TRIGGER SetAlbumTimestampOnInsert
                    AFTER INSERT ON Albums
                    BEGIN
                        UPDATE Albums
                        SET RowVersion = randomblob(8)
                        WHERE rowid = NEW.rowid;
                    END
                ");

            //Triggers for Song
            migrationBuilder.Sql(
                @"
                    CREATE TRIGGER SetSongTimestampOnUpdate
                    AFTER UPDATE ON Songs
                    BEGIN
                        UPDATE Songs
                        SET RowVersion = randomblob(8)
                        WHERE rowid = NEW.rowid;
                    END
                ");
            migrationBuilder.Sql(
                @"
                    CREATE TRIGGER SetSongTimestampOnInsert
                    AFTER INSERT ON Songs
                    BEGIN
                        UPDATE Songs
                        SET RowVersion = randomblob(8)
                        WHERE rowid = NEW.rowid;
                    END
                ");
            migrationBuilder.Sql(
                @"
                    Create View PerformanceSummaries as
                    Select p.ID, p.FirstName, p.MiddleName, p.LastName, avg(a.FeePaid) as AverageFeePaid, 
	                    Max(a.FeePaid) as HighestFeePaid, Min(a.FeePaid) as LowestFeePaid, Count(*) as NumberOfPerformances
                    From Musicians p Join Performances a
                    on p.ID = a.MusicianID
                    Group By p.ID, p.FirstName, p.MiddleName, p.LastName
                ");
            migrationBuilder.Sql(//Part 4A BOUNUS, LEFT JOIN
                @"
			        Create View PerformanceSongSummaries as
                    Select m.ID, m.FirstName, m.MiddleName, m.LastName, ifnull(avg(p.FeePaid),0) as AverageFeePaid, 
	                    ifnull(Max(p.FeePaid),0) as HighestFeePaid, ifnull(Min(p.FeePaid),0) as LowestFeePaid, Count(p.ID) as NumberOfPerformances,
                        Count(s.ID) as NumberOfSongs
                    From Musicians m left join performances p 
                        on m.ID = p.MusicianID
                        left join Songs s 
                        on s.ID = p.SongID
                    Group By m.ID, m.FirstName, m.MiddleName, m.LastName
                ");
        }
    }
}
