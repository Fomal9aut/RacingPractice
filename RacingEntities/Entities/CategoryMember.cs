using RacingEntities.Entities.RaceEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingEntities.Entities
{
    internal class CategoryMember
    {
        [Column(TypeName = "id")]
        public Guid Id { get; set; }

        [Column(TypeName = "name")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "short_name")]
        [Required]
        public string ShortName { get; set; }

        [Column(TypeName = "description")]
        
        public string Description { get; set; }

        public List<RaceClassEntity> raceClasses { get; set; }
    }
}
