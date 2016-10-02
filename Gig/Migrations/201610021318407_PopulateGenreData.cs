namespace Gig.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'HipHop')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Blues')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Metal')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1,2,3,4,5 )");
        }
    }
}
