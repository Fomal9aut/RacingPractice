using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingEntities.Entities.MemberInfoEntities
{
    internal class DocumentEntity
    {
        [Column(TypeName = "id")]
        public Guid Id { get; set; }

        [Column(TypeName = "name")]
        [Required]
        public string Name { get; set; }

        public DocumentTypeEntity DocumentTypeEntity { get; set; }
    }
}
