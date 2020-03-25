using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConquest.DataContract.Models
{
    public class FunctionBuilding : Building
    {
        [NotMapped]
        public List<Action> Actions { get; set; }
        public FunctionBuilding()
        {
            Actions = new List<Action>();
        }
    }
}
