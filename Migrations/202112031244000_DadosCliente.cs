namespace CadastroClienteFullStack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DadosCliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DadosClientes",
                c => new
                    {
                        Nome = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        CNPJ = c.String(),
                        Sexo = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Nome);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DadosClientes");
        }
    }
}
