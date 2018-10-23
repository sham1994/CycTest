namespace CycTest.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialdbcreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stock_Book",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Old_ID = c.Int(),
                        FLAGT = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Stock_Cat",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Cat_Name = c.String(),
                        Stock_Book = c.Int(),
                        Cat_Code = c.String(),
                        Item_No = c.Short(nullable: false),
                        Old_ID = c.Int(),
                        FLAGT = c.String(),
                        dis = c.Double(),
                        disamt = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stock_Cat");
            DropTable("dbo.Stock_Book");
        }
    }
}
