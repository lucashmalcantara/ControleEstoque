namespace ControleEstoque.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ControleEstoqueV1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Produtoes", newName: "Produtos");
            AlterColumn("dbo.Produtos", "Valor", c => c.Decimal(nullable: false, storeType: "money"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtos", "Valor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            RenameTable(name: "dbo.Produtos", newName: "Produtoes");
        }
    }
}
