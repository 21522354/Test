namespace entity_framework_codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHeoAndChuongHeo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChuongHeos",
                c => new
                    {
                        MaChuong = c.String(nullable: false, maxLength: 128),
                        TinhTrang = c.String(),
                        SucChuaToiDa = c.Int(nullable: false),
                        SoLuongHeo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaChuong);
            
            CreateTable(
                "dbo.Heos",
                c => new
                    {
                        Maheo = c.String(nullable: false, maxLength: 128),
                        CanNang = c.Int(nullable: false),
                        NgaySinh = c.DateTime(nullable: false),
                        TinhTrangSucKhoe = c.Boolean(nullable: false),
                        MaChuong = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Maheo)
                .ForeignKey("dbo.ChuongHeos", t => t.MaChuong)
                .Index(t => t.MaChuong);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Heos", "MaChuong", "dbo.ChuongHeos");
            DropIndex("dbo.Heos", new[] { "MaChuong" });
            DropTable("dbo.Heos");
            DropTable("dbo.ChuongHeos");
        }
    }
}
