using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingEntities.Entities.VehicleInfoEntity
{
    internal class VehicleModelEntity
    {
        [Column(TypeName = "id")]
        public Guid Id { get; set; }

        [Column(TypeName = "name")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "generation")]
        public int? Generation { get; set; }

        [Column(TypeName = "production_year")]
        [Required]
        public string ProductionYear { get; set; }

        [Column(TypeName = "engine_power")]
        [Required]
        public double EnginePower { get; set; }

        [Column(TypeName = "engine_volume")]
        [Required]
        public int EngineVolume { get; set; }

        public VehicleTypeEntity VehicleType { get; set; }
    }
}
