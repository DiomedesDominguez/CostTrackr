namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;
using DNMOFT.CostTrackr.DataAccess.Enums;

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