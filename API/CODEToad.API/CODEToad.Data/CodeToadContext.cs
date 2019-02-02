using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CODEToad.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using CODEToad.Data.Models;

    public class CodeToadContext : DbContext
    {
        // Your context has been configured to use a 'CodeToadContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CODEToad.Data.CodeToadContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CodeToadContext' 
        // connection string in the application configuration file.
        public CodeToadContext() : base("name=CodeToadData")
        {
            Database.SetInitializer<CodeToadContext>(new CreateDatabaseIfNotExists<CodeToadContext>());
        }

        //protected void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}

        public virtual DbSet<CodeNote> CodeNodes { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class DatabaseConfiguration : DbMigrationsConfiguration<CodeToadContext>
    //{
    //    public DatabaseConfiguration()
    //    {
    //        this.AutomaticMigrationsEnabled = false;
    //    }
    //}


}