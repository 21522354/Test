namespace entity_framework_codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addQuyDinh : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.quidinhs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.quidinhs");
        }
    }
}
