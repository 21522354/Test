using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace entity_framework_codefirst.Model.Database.Entity
{
    public class ChuongHeo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuongHeo()
        {
            this.Heo = new HashSet<Heo>();
        }
        [Key]
        public string MaChuong { get; set; }
        public string TinhTrang { get; set; }
        public int SucChuaToiDa { get; set; }
        public int SoLuongHeo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Heo> Heo { get; set; }
    }
}
