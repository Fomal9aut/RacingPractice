using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RacingEntities.Entities.Vehicle;
using RacingEntities.Entities.MemberInfoEntities;
using RacingEntities.Entities.RaceEntities;

namespace RacingEntities.Entities
{
    internal class RacingMemberEntity 
    {
        [Column(TypeName = "id")]
        public Guid Id { get; set; }

        [Column(TypeName = "name")]
        [Required]
        public string Name { get; set; } 

        [Column(TypeName = "surname")]
        [Required]
        public string Surname { get; set; }

        [Column(TypeName = "patronymic")]
        [Required]
        public string Patronymic {  get; set; }

        [Column(TypeName = "name_international")]
        [Required]
        public string NameInternational { get; set; }

        [Column(TypeName = "surname_international")]
        [Required]
        public string SurnameInternational { get; set; }

        [Column(TypeName = "patronymic_international")]
        [Required]
        public string PatronymicInternational { get; set; }

        [Column(TypeName = "birth_date")]
        [Required]
        public DateTime? Date { get; set; }

        [Column(TypeName = "birth_date")]
        public bool IsPublicProfile { get; set; } = true;

        [Column(TypeName = "email")]
        public string Email { get; set; } = string.Empty;

        [Column(TypeName = "insurance_date")]
        public DateTime? InsuranceDate { get; set; }

        [Required]
        [Column(TypeName = "country")]
        public CountryEntity Country { get; set; }

        [Required]
        [Column(TypeName = "city")]
        public CityEntity City { get; set; }

        [Required]
        [Column(TypeName = "house")]
        public HouseEntity House { get; set; }

        [Required]
        [Column(TypeName = "street")]
        public StreetEntity Street { get; set; }

        public List<CitizenshipEntity> Citizenship { get; set; }

        public List<VehicleEntity> Vehicles { get; set; }

        public List<PhotoEntity> Photos { get; set; }

        public List<DocumentEntity> Documents { get; set; }

        public List<LinkEntity> Links { get; set; }
        public List<TeamEntity> Teams { get; set; }

    }
}
