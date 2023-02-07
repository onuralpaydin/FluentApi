namespace FluentApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        GradeId = c.Int(nullable: false, identity: true),
                        GradeName = c.String(),
                        Section = c.String(),
                        Adress_StudentAdressId = c.Int(),
                    })
                .PrimaryKey(t => t.GradeId)
                .ForeignKey("dbo.StudentAdresses", t => t.Adress_StudentAdressId)
                .Index(t => t.Adress_StudentAdressId);
            
            CreateTable(
                "dbo.StudentAdresses",
                c => new
                    {
                        StudentAdressId = c.Int(nullable: false),
                        Address = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        AddressofStudentId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentAdressId)
                .ForeignKey("dbo.Students", t => t.StudentAdressId)
                .Index(t => t.StudentAdressId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CurrentGradeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.CurrentGradeId, cascadeDelete: true)
                .Index(t => t.CurrentGradeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Grades", "Adress_StudentAdressId", "dbo.StudentAdresses");
            DropForeignKey("dbo.Students", "CurrentGradeId", "dbo.Grades");
            DropForeignKey("dbo.StudentAdresses", "StudentAdressId", "dbo.Students");
            DropIndex("dbo.Students", new[] { "CurrentGradeId" });
            DropIndex("dbo.StudentAdresses", new[] { "StudentAdressId" });
            DropIndex("dbo.Grades", new[] { "Adress_StudentAdressId" });
            DropTable("dbo.Students");
            DropTable("dbo.StudentAdresses");
            DropTable("dbo.Grades");
        }
    }
}
