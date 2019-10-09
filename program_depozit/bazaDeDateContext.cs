using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_depozit
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using tabele;

    public class bazaDeDateContext : DbContext
    {
        // Your context has been configured to use a 'bazaDeDateContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MainSocialCenter.bazaDeDateContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'bazaDeDateContext' 
        // connection string in the application configuration file.
        public bazaDeDateContext(): base("name=bazaDeDateContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        //public DbSet<WMS_test> tabel_wms_test { get; set; }
        public DbSet<Furnizor> tabel_Furnizor { get; set; }
        public DbSet<Client> tabel_Client { get; set;  }
        public DbSet<Produse> tabel_Produse { get; set;  }
        public DbSet<User> tabel_User { get; set;  }


    }


}