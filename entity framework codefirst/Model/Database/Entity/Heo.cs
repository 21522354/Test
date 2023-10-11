using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace entity_framework_codefirst.Model.Database.Entity
{
    public class Heo
    {
        [Key]
        public string Maheo { get; set; }
        public int CanNang { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool TinhTrangSucKhoe { get; set; }
        public string MaChuong { get; set; }
        public virtual ChuongHeo ChuongHeo { get; set; }
    }
}
