namespace CODEToad.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CodeNote",
                c => new
                    {
                        CodeNoteId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        URL = c.String(),
                        Snippet = c.String(),
                        UpdateDate = c.DateTime(nullable: false),
                        StatusCode = c.String(nullable: false, maxLength: 1),
                    })
                .PrimaryKey(t => t.CodeNoteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CodeNote");
        }
    }
}
