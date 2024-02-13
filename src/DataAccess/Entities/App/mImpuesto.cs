namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;

[Table("mImpuestos")]
public class mImpuesto : BaseEntity
{
    /// <summary>
    ///     Gets or sets the descripcion.
    /// </summary>
    /// <value>The descripcion.</value>
    [MaxLength(120)]
    public string Descripcion { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the nombre.
    /// </summary>
    /// <value>The nombre.</value>
    [Required]
    [MaxLength(30)]
    public string Nombre { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the tasa.
    /// </summary>
    /// <value>The tasa.</value>
    [Required]
    [Range(0, 100)]
    public decimal Tasa { get; set; }

}