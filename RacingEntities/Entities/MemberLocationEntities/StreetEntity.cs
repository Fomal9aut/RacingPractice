﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace RacingEntities.Entities
{
    public class StreetEntity
    {
        [Column(TypeName = "id")]
        public Guid Id { get; set; }

        [Column(TypeName = "name")]
        [Required]
        public string Name { get; set; }

        public List<HouseEntity> Houses { get; set; }
    }
}