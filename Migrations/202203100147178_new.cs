namespace MovieLab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "GenreId_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId_Id" });
            RenameColumn(table: "dbo.Movies", name: "Genre_Id", newName: "GenreId");
            RenameIndex(table: "dbo.Movies", name: "IX_Genre_Id", newName: "IX_GenreId");
            //DropColumn("dbo.Movies", "GenreId_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GenreId_Id", c => c.Byte());
            RenameIndex(table: "dbo.Movies", name: "IX_GenreId", newName: "IX_Genre_Id");
            RenameColumn(table: "dbo.Movies", name: "GenreId", newName: "Genre_Id");
            CreateIndex("dbo.Movies", "GenreId_Id");
            AddForeignKey("dbo.Movies", "GenreId_Id", "dbo.Genres", "Id");
        }
    }
}
