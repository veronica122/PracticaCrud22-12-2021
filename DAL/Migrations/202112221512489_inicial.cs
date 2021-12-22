namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        IdPersona = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false),
                        Apellidos = c.String(nullable: false),
                        Edad = c.Int(nullable: false),
                        Sexo = c.Boolean(nullable: false),
                        Telefono = c.String(nullable: false),
                        Direccion = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdPersona);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personas");
        }
    }
}
