namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;

[Table("mCompaniasTransportes")]
public class mCompaniaTransporte : BaseEntity
{

    [MaxLength(7)]
    public string Codigo { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    [MinLength(3)]
    public string Nombre { get; set; } = string.Empty;
}