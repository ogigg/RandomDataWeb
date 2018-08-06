namespace RandomDataWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstNameTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FirstNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.RandomDataViewModels", "State", c => c.String());
            DropColumn("dbo.RandomDataViewModels", "Country");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RandomDataViewModels", "Country", c => c.String());
            DropColumn("dbo.RandomDataViewModels", "State");
            DropTable("dbo.FirstNames");
        }
    }
}
