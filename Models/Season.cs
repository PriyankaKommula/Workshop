using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebApplication6.Models
{
    public class Season
    {
        [ScaffoldColumn(false)]
        [Key]
        public int SeasonId { get; set; }
        public int SeasonName { get; set; }
        public int TimePeriod { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}
