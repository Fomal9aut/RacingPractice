using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RacingEntities.Entities.VehicleInfoEntity;

namespace RacingEntities.Entities.RaceEntities
{
    internal class RaceEntity
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
        [Column(TypeName = "race_location")]
        [Required]
        public string RaceLocation { get; set; } = string.Empty;

        [Column(TypeName = "race_date")]
        [Required]
        public DateTime RaceDate { get; set; }

        [Column(TypeName = "max_members_count")]
        [Required]
        public int MaxCountMembers { get; set; }

        [Column(TypeName = "min_members_count")]
        [Required]
        public int MinimalCountMembers { get; set; }

        [Column(TypeName = "regulation_link")]
        [Required]
        public string RegulationLink { get; set; }

        public List<RaceClassEntity> raceClasses { get; set; }
        public List<OrganizerEntity> Organizer { get; set; }
        public List<TeamEntity> teams { get; set; }

    }
}
