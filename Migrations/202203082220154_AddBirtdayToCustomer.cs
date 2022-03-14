namespace MovieLab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirtdayToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            DropColumn("dbo.MembershipTypes", "Birthdate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "Birthdate", c => c.DateTime());
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
