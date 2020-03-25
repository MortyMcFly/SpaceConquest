using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConquest.DataContract.Models
{
    public class SolarSystem : IDbEntity
    {
        public long? Id { get; set; }
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Le nom doit contenir entre 5 et 20 caractères.")]
        public string Name { get; set; }
    }
}
