namespace program_depozit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Filiala = c.String(),
                        NumeClient = c.String(),
                        CodClient = c.String(),
                        CodTvaClient = c.String(),
                        NrReg = c.String(),
                        AdresaSediu = c.String(),
                        AdresaDeLivrare = c.String(),
                        PersoanaDeContact = c.String(),
                        Email = c.String(),
                        Telefon = c.String(),
                        ZonaClient = c.String(),
                        Judet = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Furnizors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NumeFurnizor = c.String(),
                        CodFurnizor = c.String(),
                        AdresaSediuSocial = c.String(),
                        AdresaDeLivrare = c.String(),
                        PersoanaDeContact = c.String(),
                        Email = c.String(),
                        AlteDetalii = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Produses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NumeProdus = c.String(),
                        CodProdus = c.String(),
                        CodBare = c.String(),
                        Furnizor = c.String(),
                        CodProdusFurnizor = c.String(),
                        UM = c.String(),
                        BucatiInBax = c.String(),
                        NrBaxuriInLayer = c.String(),
                        NrStraturiPePalet = c.String(),
                        GreutateProdusKg = c.String(),
                        GreutateNetaProdusKg = c.String(),
                        LungimeCm = c.String(),
                        LatimeCm = c.String(),
                        InaltimeCm = c.String(),
                        TipProdus = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nume = c.String(),
                        Pass = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Produses");
            DropTable("dbo.Furnizors");
            DropTable("dbo.Clients");
        }
    }
}
