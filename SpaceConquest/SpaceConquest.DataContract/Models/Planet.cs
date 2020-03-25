using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SpaceConquest.DataContract.Models
{
    public class Planet : IDbEntity
    {
        public long? Id { get; set; }
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Le nom doit contenir entre 5 et 20 caractères.")]
        public string Name { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "La valeur doit être positive.")]
        public int? CaseNb { get; set; }
        public SolarSystem SolarSystem { get; set; }
        public Dictionary<ResourceType, Resource> Resources { get; set; }
        public List<Building> Buildings { get; set; }
        public Planet()
        {
            Resources = new Dictionary<ResourceType, Resource>();
            Resources.Add(ResourceType.Energy, new Resource { ResourceType = ResourceType.Energy });
            Resources.Add(ResourceType.Oxygen, new Resource { ResourceType = ResourceType.Oxygen });
            Resources.Add(ResourceType.Steel, new Resource { ResourceType = ResourceType.Steel });
            Resources.Add(ResourceType.Uranium, new Resource { ResourceType = ResourceType.Uranium });

            Buildings = new List<Building>();
        }
    }
}