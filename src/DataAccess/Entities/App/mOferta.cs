namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;
[Table("mOfertas")]
public class mOferta : BaseEntity
{

    /// <summary>
    ///     Initializes a new instance of the <see cref="mOferta" /> class.
    /// </summary>
    public mOferta()
    {
        Details = new HashSet<mOfertaDetail>();
    }


    /// <summary>
    ///     Gets or sets the cantidad.
    /// </summary>
    /// <value>The cantidad.</value>
    public uint Cantidad { get; set; }

    /// <summary>
    ///     Gets or sets the clasificacion cliente.
    /// </summary>
    /// <value>The clasificacion cliente.</value>
    public virtual mClasificacionCliente ClasificacionCliente { get; set; }

    /// <summary>
    ///     Gets or sets the clasificacion cliente identifier.
    /// </summary>
    /// <value>The clasificacion cliente identifier.</value>
    public long ClasificacionClienteId { get; set; }

    [NotMapped]
    public decimal Descuento
    {
        get
        {
            if (Details != null && Details.Count > 0)
            {
                return Details.Sum(x => x.Descuento);
            }
            return 0;
        }
    }

    /// <summary>
    ///     Gets or sets the desde.
    /// </summary>
    /// <value>The desde.</value>
    public DateTime Desde { get; set; }

    /// <summary>
    ///     Gets or sets the details.
    /// </summary>
    /// <value>The details.</value>
    public virtual ICollection<mOfertaDetail> Details { get; set; }

    /// <summary>
    ///     Gets or sets the disponibles.
    /// </summary>
    /// <value>The disponibles.</value>
    public uint Disponibles { get; set; }

    /// <summary>
    ///     Gets or sets the hasta.
    /// </summary>
    /// <value>The hasta.</value>
    public DateTime? Hasta { get; set; }

    /// <summary>
    ///     Gets or sets the nombre.
    /// </summary>
    /// <value>The nombre.</value>
    public string Nombre { get; set; }

    /// <summary>
    ///     Gets or sets the nota.
    /// </summary>
    /// <value>The nota.</value>
    public string Nota { get; set; }

    [NotMapped]
    public decimal Precio
    {
        get
        {
            if (Details != null && Details.Count > 0)
            {
                return Details.Sum(x => x.Total);
            }
            return 0;
        }
    }

}
