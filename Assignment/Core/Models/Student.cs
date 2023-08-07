using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Core.Models
{
    public class Student
    {
        #region Properties
        [Key]
        [MaxLength(50)]
        public string MaSV { get; set; }
        [MaxLength(50)]
        public string HoTen { get; set; }
        [MaxLength(50)]
        public string? Email { get; set; }
        [MaxLength(20)]
        public string? SoDT { get; set; }
        public bool GioiTinh { get; set; }
        [MaxLength(100)]
        public string? DiaChi { get; set; }
        [MaxLength(-1)]
        public byte[]? Hinh { get; set; }
        public ICollection<Grade> Grades { get; set; } 
        #endregion
    }
}
