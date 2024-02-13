namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;
using DNMOFT.CostTrackr.DataAccess.Enums;

[Table("mPresentaciones")]
public class mPresentacion : BaseEntity
{
    [DecimalPrecision]
    public decimal Alto { get; set; }

    [DecimalPrecision]
    public decimal Ancho { get; set; }

    public short Cantidad { get; set; }

    public string Descripcion { get; set; } = string.Empty;

    [DecimalPrecision]
    public decimal Largo { get; set; }

    public string Nombre { get; set; } = string.Empty;

    [DecimalPrecision]
    public decimal Peso { get; set; }

    [NotMapped]
    public decimal TotalDimension => Alto * Ancho * Largo;
}