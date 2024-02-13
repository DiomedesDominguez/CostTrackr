namespace DNMOFT.CostTrackr.DataAccess.Entities.App;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;

[Table("mClasificacionesClientes")]
public class mClasificacionCliente : BaseEntity
{
    [MaxLength(15)]
    public string Codigo { get; set; } = "";

    [MaxLength(550)]
    public string Descripcion { get; set; } = "";

    [Required]
    [StringLength(40, MinimumLength = 3)]
    public string Nombre { get; set; } = "";
}