namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;

[Table("mProductosFamilias")]
public class mProductoFamilia : BaseEntity
{
    [MaxLength(200)]
    public string Descripcion { get; set; } = string.Empty;

    [Required]
    [MaxLength(30)]
    public string Nombre { get; set; } = string.Empty;
}
