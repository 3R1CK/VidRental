namespace VidRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTyesNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name='Pay as You Go' WHERE DiscountRate=0 ");
            Sql("UPDATE MembershipTypes SET Name='Monthly' WHERE DiscountRate=10 ");
            Sql("UPDATE MembershipTypes SET Name='Quaterly' WHERE DiscountRate=15 ");
            Sql("UPDATE MembershipTypes SET Name='Annually' WHERE DiscountRate=20 ");
        }
        
        public override void Down()
        {
        }
    }
}
