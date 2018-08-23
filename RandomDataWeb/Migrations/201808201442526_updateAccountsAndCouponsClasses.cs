namespace RandomDataWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAccountsAndCouponsClasses : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "Email", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Accounts", "Password", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Coupons", "CouponCode", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Coupons", "CouponCode", c => c.String());
            AlterColumn("dbo.Accounts", "Password", c => c.String());
            AlterColumn("dbo.Accounts", "Email", c => c.String());
        }
    }
}
