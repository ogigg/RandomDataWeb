namespace RandomDataWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RandomDataViewModelDeleted : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.RandomDataViewModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RandomDataViewModels",
                c => new
                    {
                        FirstName = c.String(nullable: false, maxLength: 128),
                        LastName = c.String(),
                        Street = c.String(),
                        Number = c.Byte(nullable: false),
                        ZipCode = c.String(),
                        City = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.FirstName);
            
        }
    }
}
