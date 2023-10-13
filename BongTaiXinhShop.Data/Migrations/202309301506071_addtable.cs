namespace BongTaiXinhShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientCategorys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 256),
                        Name2 = c.String(maxLength: 256),
                        Address = c.String(maxLength: 256),
                        Phone = c.String(maxLength: 25),
                        Email = c.String(maxLength: 256),
                        Fax = c.String(maxLength: 128),
                        Masothue = c.String(maxLength: 128),
                        GroupClient1 = c.String(maxLength: 128),
                        GroupClient2 = c.String(maxLength: 128),
                        GroupClient3 = c.String(maxLength: 128),
                        Bank = c.String(maxLength: 256),
                        BankAccountNumber = c.String(maxLength: 128),
                        Note = c.String(maxLength: 128),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClientCategorys");
        }
    }
}
