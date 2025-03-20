﻿namespace Gestion_d_ecole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creation_des_tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomClasse = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClasseCours",
                c => new
                    {
                        IdClasse = c.Int(nullable: false),
                        IdCours = c.Int(nullable: false),
                        Classe_Id = c.Int(),
                        Cours_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.IdClasse, t.IdCours })
                .ForeignKey("dbo.Classes", t => t.Classe_Id)
                .ForeignKey("dbo.Cours", t => t.Cours_Id)
                .Index(t => t.Classe_Id)
                .Index(t => t.Cours_Id);
            
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomCours = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CoursMatieres",
                c => new
                    {
                        IdCours = c.Int(nullable: false),
                        IdMatiere = c.Int(nullable: false),
                        Cours_Id = c.Int(),
                        Matiere_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.IdCours, t.IdMatiere })
                .ForeignKey("dbo.Cours", t => t.Cours_Id)
                .ForeignKey("dbo.Matieres", t => t.Matiere_Id)
                .Index(t => t.Cours_Id)
                .Index(t => t.Matiere_Id);
            
            CreateTable(
                "dbo.Matieres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomMatiere = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfesseurMatieres",
                c => new
                    {
                        IdProfesseur = c.Int(nullable: false),
                        IdMatiere = c.Int(nullable: false),
                        Matiere_Id = c.Int(),
                        Professeur_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.IdProfesseur, t.IdMatiere })
                .ForeignKey("dbo.Matieres", t => t.Matiere_Id)
                .ForeignKey("dbo.Professeurs", t => t.Professeur_Id)
                .Index(t => t.Matiere_Id)
                .Index(t => t.Professeur_Id);
            
            CreateTable(
                "dbo.Professeurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Email = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfesseurClasses",
                c => new
                    {
                        IdProfesseur = c.Int(nullable: false),
                        IdClasse = c.Int(nullable: false),
                        Classe_Id = c.Int(),
                        Professeur_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.IdProfesseur, t.IdClasse })
                .ForeignKey("dbo.Classes", t => t.Classe_Id)
                .ForeignKey("dbo.Professeurs", t => t.Professeur_Id)
                .Index(t => t.Classe_Id)
                .Index(t => t.Professeur_Id);
            
            CreateTable(
                "dbo.Etudiants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matricule = c.String(),
                        Nom = c.String(),
                        Prenom = c.String(),
                        DateNaissance = c.DateTime(nullable: false),
                        Sexe = c.String(),
                        Adresse = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        IdClasse = c.Int(nullable: false),
                        Classe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Classe_Id)
                .Index(t => t.Classe_Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEtudiant = c.Int(nullable: false),
                        IdMatiere = c.Int(nullable: false),
                        ValeurNote = c.Single(nullable: false),
                        Etudiant_Id = c.Int(),
                        Matiere_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Etudiants", t => t.Etudiant_Id)
                .ForeignKey("dbo.Matieres", t => t.Matiere_Id)
                .Index(t => t.Etudiant_Id)
                .Index(t => t.Matiere_Id);
            
            CreateTable(
                "dbo.OTPCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUtilisateur = c.Int(nullable: false),
                        Code = c.String(),
                        DateExpiration = c.DateTime(nullable: false),
                        Utilisateur_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilisateurs", t => t.Utilisateur_Id)
                .Index(t => t.Utilisateur_Id);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomUtilisateur = c.String(),
                        MotDePasse = c.String(),
                        Role = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OTPCodes", "Utilisateur_Id", "dbo.Utilisateurs");
            DropForeignKey("dbo.Notes", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.Notes", "Etudiant_Id", "dbo.Etudiants");
            DropForeignKey("dbo.Etudiants", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.ProfesseurMatieres", "Professeur_Id", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseurClasses", "Professeur_Id", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseurClasses", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.ProfesseurMatieres", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.CoursMatieres", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.CoursMatieres", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.ClasseCours", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.ClasseCours", "Classe_Id", "dbo.Classes");
            DropIndex("dbo.OTPCodes", new[] { "Utilisateur_Id" });
            DropIndex("dbo.Notes", new[] { "Matiere_Id" });
            DropIndex("dbo.Notes", new[] { "Etudiant_Id" });
            DropIndex("dbo.Etudiants", new[] { "Classe_Id" });
            DropIndex("dbo.ProfesseurClasses", new[] { "Professeur_Id" });
            DropIndex("dbo.ProfesseurClasses", new[] { "Classe_Id" });
            DropIndex("dbo.ProfesseurMatieres", new[] { "Professeur_Id" });
            DropIndex("dbo.ProfesseurMatieres", new[] { "Matiere_Id" });
            DropIndex("dbo.CoursMatieres", new[] { "Matiere_Id" });
            DropIndex("dbo.CoursMatieres", new[] { "Cours_Id" });
            DropIndex("dbo.ClasseCours", new[] { "Cours_Id" });
            DropIndex("dbo.ClasseCours", new[] { "Classe_Id" });
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.OTPCodes");
            DropTable("dbo.Notes");
            DropTable("dbo.Etudiants");
            DropTable("dbo.ProfesseurClasses");
            DropTable("dbo.Professeurs");
            DropTable("dbo.ProfesseurMatieres");
            DropTable("dbo.Matieres");
            DropTable("dbo.CoursMatieres");
            DropTable("dbo.Cours");
            DropTable("dbo.ClasseCours");
            DropTable("dbo.Classes");
        }
    }
}
