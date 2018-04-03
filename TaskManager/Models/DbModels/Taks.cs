using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.DbModels
{
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Description { get; set; }
        public int Priority { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FinishTime { get; set; }

        [Required]
        public int StatusId { get; set; }
        public Status Status { get; set; }
        [Required]
        public int ListId { get; set; }
        public List List { get; set; }
    }
}
