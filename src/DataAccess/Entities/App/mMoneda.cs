using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;

namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
[Table("mMonedas")]
public class mMoneda : BaseEntity
{
    public string Nombre { get; set; } = string.Empty;
    public string Simbolo { get; set; } = string.Empty;
    public string ISO { get; set; } = string.Empty;
    public bool EsPrimaria { get; set; }
    [DecimalPrecision]
    public decimal Tasa { get; set; }

}