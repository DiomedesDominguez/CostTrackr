namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;
using DNMOFT.CostTrackr.DataAccess.Enums;

[Table("mOrdenes")]
public class mOrden : BaseEntity
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="mOrden" /> class.
    /// </summary>
    public mOrden()
    {
        Details = new HashSet<mOrdenDetail>();
    }

    /// <summary>
    ///     Gets or sets the cliente.
    /// </summary>
    /// <value>The cliente.</value>
    public virtual mCliente Cliente { get; set; }

    /// <summary>
    ///     Gets or sets the cliente identifier.
    /// </summary>
    /// <value>The cliente identifier.</value>
    public long ClienteId { get; set; }

    /// <summary>
    ///     Gets or sets the cliente nombre.
    /// </summary>
    /// <value>The cliente nombre.</value>
    public string ClienteNombre { get; set; }

    /// <summary>
    ///     Gets or sets the details.
    /// </summary>
    /// <value>The details.</value>
    public virtual ICollection<mOrdenDetail> Details { get; set; }

    /// <summary>
    ///     Gets or sets the entregar.
    /// </summary>
    /// <value>The entregar.</value>
    public DateTime? Entregar { get; set; }

    /// <summary>
    ///     Gets or sets the factura.
    /// </summary>
    /// <value>The factura.</value>
    public string Factura { get; set; }

    /// <summary>
    ///     Gets or sets the factura NCF.
    /// </summary>
    /// <value>The factura NCF.</value>
    public string FacturaNCF { get; set; }

    /// <summary>
    ///     Gets or sets the nota.
    /// </summary>
    /// <value>The nota.</value>
    public string Nota { get; set; }

    /// <summary>
    ///     Gets or sets the numero.
    /// </summary>
    /// <value>The numero.</value>
    public string Numero { get; set; }

    /// <summary>
    ///     Gets or sets the vendedor.
    /// </summary>
    /// <value>The vendedor.</value>
    public virtual mVendedor Vendedor { get; set; }

    /// <summary>
    ///     Gets or sets the vendedor identifier.
    /// </summary>
    /// <value>The vendedor identifier.</value>
    public long VendedorId { get; set; }

    /// <summary>
    ///     Gets or sets the vendedor nombre.
    /// </summary>
    /// <value>The vendedor nombre.</value>
    public string VendedorNombre { get; set; }
}