namespace CRUDCliente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PPeka : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Livros",
                c => new
                    {
                        IdLivro = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Coletanea = c.String(),
                        Ano = c.String(),
                    })
                .PrimaryKey(t => t.IdLivro);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        IdPessoa = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CPF = c.String(),
                    })
                .PrimaryKey(t => t.IdPessoa);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pessoas");
            DropTable("dbo.Livros");
        }
    }
}
