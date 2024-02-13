using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Entities.App
{
    [Table("mSucursales")]
    public class mSucursal
    {
         [MaxLength(100)]
        public string Descripcion { get; set; }

        [MaxLength(23)]
        public string Documento { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Nombre { get; set; }

        public TipoDocumento TipoDocumento { get; set; }
    }
}