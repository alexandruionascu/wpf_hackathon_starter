namespace IT_Fest_Hackathon
{
    using IT_Fest_Hackathon.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SchoolContext : DbContext
    {
        // Your context has been configured to use a 'SchoolDbModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'IT_Fest_Hackathon.SchoolDbModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SchoolDbModel' 
        // connection string in the application configuration file.
        public SchoolContext()
            : base("name=SchoolDbModel")
        {
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Class> classes { get; set; }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}