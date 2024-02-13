namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;
using DNMOFT.CostTrackr.DataAccess.Enums;

[Table("mTiposProveedores")]
public class mTipoProveedor : BaseEntity
{
    [MaxLength(120)]
    public string Descripcion { get; set; } = string.Empty;

    [Required]
    [MaxLength(30)]
    public string Nombre { get; set; } = string.Empty;
}