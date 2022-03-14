namespace MovieLab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4bad625a-efa4-4cae-99b8-04064c70c3c7', N'admin@movielab.com', 0, N'AO1qMbXPB5GCqyTPZKtk2gqZeZD11Zd0+DoVCGlsUY6N3II9AXQJ9Gpoc6CqdLJj1g==', N'a80fcea5-9e8a-4d25-8eb6-bac69ca3edd6', NULL, 0, 0, NULL, 1, 0, N'admin@movielab.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b934b925-98af-464c-91be-8dfb8dcd6ac8', N'guest@movielab.com', 0, N'ALyTN6ACj7gszZXKtuHx2dLFuO2YXdl6XsokdUJ9Jcj4eae1DPS0oqKI/8wd7c/NZQ==', N'db215a7d-f23e-4457-8ce0-bf844c6bd5b7', NULL, 0, 0, NULL, 1, 0, N'guest@movielab.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'67c5fe6d-a2b1-46de-909e-d79deb4c51c3', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4bad625a-efa4-4cae-99b8-04064c70c3c7', N'67c5fe6d-a2b1-46de-909e-d79deb4c51c3')

");
        }
        
        public override void Down()
        {
        }
    }
}
