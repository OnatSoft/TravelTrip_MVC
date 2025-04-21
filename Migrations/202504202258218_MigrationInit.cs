namespace TravelTrip_MVCProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminTBLs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KullaniciAd = c.String(),
                        Sifre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AdresTBLs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        AcikAdres = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BlogTBLs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        Tarih = c.DateTime(nullable: false),
                        Aciklama = c.String(),
                        BlogFoto = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.YorumlarTBLs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Email = c.String(),
                        Yorum = c.String(),
                        Blogid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BlogTBLs", t => t.Blogid, cascadeDelete: true)
                .Index(t => t.Blogid);
            
            CreateTable(
                "dbo.HakkimizdaTBLs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Aciklama = c.String(),
                        FotoUrl = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.iletisimTBLs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(),
                        Konu = c.String(),
                        Mail = c.String(),
                        Telefon = c.String(),
                        Mesaj = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.YorumlarTBLs", "Blogid", "dbo.BlogTBLs");
            DropIndex("dbo.YorumlarTBLs", new[] { "Blogid" });
            DropTable("dbo.iletisimTBLs");
            DropTable("dbo.HakkimizdaTBLs");
            DropTable("dbo.YorumlarTBLs");
            DropTable("dbo.BlogTBLs");
            DropTable("dbo.AdresTBLs");
            DropTable("dbo.AdminTBLs");
        }
    }
}
