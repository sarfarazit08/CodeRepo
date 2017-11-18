using System.Data.Entity;

namespace Mvc4WebBootstrap.Models
{
    public class Mvc4Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
         

        public Mvc4Context() : base("name=Mvc4Context")
        {
            
        }

        public DbSet<Registration> Registrations { get; set; }

        public DbSet<Login> LoginModels { get; set; }        
    }
}
