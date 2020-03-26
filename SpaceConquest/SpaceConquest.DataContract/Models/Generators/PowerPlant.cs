using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConquest.DataContract.Models.Generators
{
    public class PowerPlant : ResourceGenerator
    {
        public new List<Resource> TotalCost()
        {
            return TotalCost();
        }
        public new List<Resource> NextCost()
        {
            return new List<Resource>
            {
                new Resource { ResourceType = ResourceType.Energy, LastQuantity = 1 * Level},
                new Resource { ResourceType = ResourceType.Oxygen, LastQuantity = 1 * Level + (200 * (Level/10)) + 20},
                new Resource { ResourceType = ResourceType.Steel, LastQuantity = 1 * Level + (100 * (Level/8)) + 20},
                new Resource { ResourceType = ResourceType.Uranium, LastQuantity = 1 * Level * Level * Level + (200 * (Level/20)) + 20}
            };
        }
        public new List<Resource> ResourceBySecond()
        {
            return new List<Resource>
            {
                new Resource { ResourceType = ResourceType.Energy, LastQuantity = 3 * Level + 10}
            };
        }
    }
}
