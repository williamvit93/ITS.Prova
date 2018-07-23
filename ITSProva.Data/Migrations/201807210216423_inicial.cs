namespace ITSProva.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        FuncionarioId = c.Int(nullable: false, identity: true),
                        NomeCompleto = c.String(),
                        Rg = c.String(),
                        Cpf = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        DataDemissao = c.DateTime(),
                        DataAdmissao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FuncionarioId);
            
            CreateTable(
                "dbo.Ferias",
                c => new
                    {
                        FuncionarioId = c.Int(nullable: false),
                        DataInicio = c.DateTime(nullable: false),
                        DataTermino = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FuncionarioId)
                .ForeignKey("dbo.Funcionarios", t => t.FuncionarioId)
                .Index(t => t.FuncionarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ferias", "FuncionarioId", "dbo.Funcionarios");
            DropIndex("dbo.Ferias", new[] { "FuncionarioId" });
            DropTable("dbo.Ferias");
            DropTable("dbo.Funcionarios");
        }
    }
}
