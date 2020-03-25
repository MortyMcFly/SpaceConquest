using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaceConquest.DataContract.Models
{
    public abstract class Building : IDbEntity
    {
        public long? Id { get; set; }
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Le nom doit contenir entre 5 et 20 caractères.")]
        public string Name { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "La valeur doit être positive.")]
        public int? Level { get; set; }
        [NotMapped]
        public virtual int? CellNb
        {
            get { return Level; }
        }

        [NotMapped]
        public virtual List<Resource> TotalCost
        {
            get { return new List<Resource>(); }
        }

        [NotMapped]
        public virtual List<Resource> NextCost
        {
            get { return new List<Resource>(); }
        }
    }
}