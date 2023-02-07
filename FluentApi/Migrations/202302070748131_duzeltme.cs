namespace FluentApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class duzeltme : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Grades", "Adress_StudentAdressId", "dbo.StudentAdresses");
            DropIndex("dbo.Grades", new[] { "Adress_StudentAdressId" });
            DropColumn("dbo.Grades", "Adress_StudentAdressId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Grades", "Adress_StudentAdressId", c => c.Int());
            CreateIndex("dbo.Grades", "Adress_StudentAdressId");
            AddForeignKey("dbo.Grades", "Adress_StudentAdressId", "dbo.StudentAdresses", "StudentAdressId");
        }
    }
}
