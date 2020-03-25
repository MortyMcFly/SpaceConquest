using SpaceConquest.DataContract.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConquest.DataContract.Models
{
    public class Resource : IDbEntity
    {
        public long? Id { get; set; }
        public ResourceType ResourceType { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "La valeur doit être positive.")]
        public int? LastQuantity { get; set; }
        [CurrentDate(ErrorMessage = "La date doit être supérieure à la date actuelle")]
        public DateTime LastUpdate { get; set; }
    }
}
