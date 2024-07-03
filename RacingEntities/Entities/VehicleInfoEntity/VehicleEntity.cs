using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RacingEntities.Entities.VehicleInfoEntity;

namespace RacingEntities.Entities.Vehicle
{
    internal class VehicleEntity
    {
        [Column(TypeName = "id")]
        public Guid Id { get; set; }

        public VehicleBrandEntity brand { get; set; }

        public VehicleModelEntity model { get; set; }

        public List<RacingMemberEntity> members { get; set; }

        public double EnginePower 
        { 
            get { return model.EnginePower; }
        }

        public double EngineVolume
        {
            get { return model.EngineVolume; }
        }

        public string ProductionYear
        {
            get { return model.ProductionYear; }
        }

        public string ModelName
        {
            get { return model.Name; }
        }
    }
}
