using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Core.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        public float TiengAnh { get; set; }
        public float TinHoc { get; set; }
        public float GDTC { get; set; }
        [ForeignKey("Student")]
        [MaxLength(50)]
        public string MaSV { get; set; }
        public Student Student { get; set; }
    }
}
