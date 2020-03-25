using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SpaceConquest.Data
{
    public class SpaceConquestContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SpaceConquestContext() : base("name=SpaceConquestContext")
        {
        }

        public System.Data.Entity.DbSet<SpaceConquest.DataContract.Models.SolarSystem> SolarSystems { get; set; }

        public System.Data.Entity.DbSet<SpaceConquest.DataContract.Models.Planet> Planets { get; set; }

        public System.Data.Entity.DbSet<SpaceConquest.DataContract.Models.Resource> Resources { get; set; }

        public System.Data.Entity.DbSet<SpaceConquest.DataContract.Models.FunctionBuilding> FunctionBuildings { get; set; }

        public System.Data.Entity.DbSet<SpaceConquest.DataContract.Models.ResourceGenerator> ResourceGenerators { get; set; }
    }
}
