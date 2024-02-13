namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;
using DNMOFT.CostTrackr.DataAccess.Enums;

[Table("mTransportes")]
public class mTransporte : BaseEntity
{
    [DecimalPrecision(10)]
    public decimal Alto { get; set; }

    [Required]
    [DecimalPrecision(10)]
    public decimal Ancho { get; set; }

    [Required]
    [DecimalPrecision(10)]
    public decimal Capacidad { get; set; }

    [NotMapped]
    public decimal Dimension => Largo * Ancho * Alto;


    [Required]
    [DecimalPrecision(10)]
    public decimal Largo { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nombre { get; set; } = string.Empty;
}