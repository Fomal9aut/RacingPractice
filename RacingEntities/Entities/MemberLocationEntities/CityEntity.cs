using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace RacingEntities.Entities
{
    public class CityEntity
    {
        [Column(TypeName = "id")]
        public Guid Id { get; set; }

        [Column(TypeName = "name")]
        [Required]
        public string Name { get; set; }

        public List<StreetEntity> Streets { get; set; }
    }
}