namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;
using DNMOFT.CostTrackr.DataAccess.Enums;

[Table("mDistribuciones")]
public class mDistribucion : BaseEntity
{
    /// <summary>
    ///     Gets or sets the desde.
    /// </summary>
    /// <value>The desde.</value>
    [Required]
    public DateTime Desde { get; set; }

    /// <summary>
    ///     Gets or sets the hasta.
    /// </summary>
    /// <value>The hasta.</value>
    public DateTime? Hasta { get; set; }

    /// <summary>
    ///     Gets or sets the vendedor.
    /// </summary>
    /// <value>The vendedor.</value>
    public virtual mVendedor Vendedor { get; set; }

    /// <summary>
    ///     Gets or sets the vendedor identifier.
    /// </summary>
    /// <value>The vendedor identifier.</value>
    public long? VendedorId { get; set; }

    /// <summary>
    ///     Gets or sets the zona.
    /// </summary>
    /// <value>The zona.</value>
    public virtual mZona Zona { get; set; }

    /// <summary>
    ///     Gets or sets the zona identifier.
    /// </summary>
    /// <value>The zona identifier.</value>
    [Required]
    public long ZonaId { get; set; }

    public long CantClientes { get; set; }

}