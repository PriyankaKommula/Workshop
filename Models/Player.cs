using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication6.Models
{
    public class Player
    {
       

        [ScaffoldColumn(false)]
        [Key]
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        
       [ForeignKey("SeasonId")]
        public int SeasonId { get; set; }
   // public virtual Season Season { get; set; }
    }
}
