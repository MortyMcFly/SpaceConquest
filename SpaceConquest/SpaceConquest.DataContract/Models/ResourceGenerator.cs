using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConquest.DataContract.Models
{
    public class ResourceGenerator : Building
    {
        public List<Resource> ResourceBySecond { get; set; }
        public ResourceGenerator()
        {
            ResourceBySecond = new List<Resource>();
        }
    }
}
