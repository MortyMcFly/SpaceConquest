using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConquest.DataContract.Models.Generators
{
    public class SteelGenerator : ResourceGenerator
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
                new Resource { ResourceType = ResourceType.Oxygen, LastQuantity = 2 * Level * Level * Level + (300 * (Level/6)) + 50},
                new Resource { ResourceType = ResourceType.Steel, LastQuantity = 100 * (Level/8) + 20},
                new Resource { ResourceType = ResourceType.Uranium, LastQuantity = 7 * Level * Level * Level + (200 * (Level/12)) + 20}
            };
        }
        public new List<Resource> ResourceBySecond()
        {
            return new List<Resource>
            {
                new Resource { ResourceType = ResourceType.Oxygen, LastQuantity = 10 * (Level / 2) + 1 }
            };
        }
    }
}
