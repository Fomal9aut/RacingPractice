using RacingEntities.Entities.VehicleInfoEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingEntities.Entities.RaceEntities
{
    internal class RaceClassEntity
    {
        [Column(TypeName = "id")]
        public Guid Id { get; set; }

        [Column(TypeName = "name")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "description")]
        [Required]
        public string Description { get; set; } = string.Empty;

        public List<TeamEntity> Teams { get; set; }

        public List<VehicleTypeEntity> VehicleTypes { get; set; }
    }
}
