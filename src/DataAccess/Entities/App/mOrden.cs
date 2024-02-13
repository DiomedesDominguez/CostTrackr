namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;
using DNMOFT.CostTrackr.DataAccess.Enums;

[Table("mOrdenes")]
public class mOrden : BaseEntity
{
    public mOrden()
    {
        Details = new HashSet<mOrdenDetail>();
    }

    public virtual mCliente? Cliente { get; set; }

    public long ClienteId { get; set; }

    public string ClienteNombre { get; set; } = string.Empty;

    public virtual ICollection<mOrdenDetail> Details { get; set; }

    public DateTime? Entregar { get; set; }

    public string Nota { get; set; } = string.Empty;

    public string Numero { get; set; } = string.Empty;

    public virtual mVendedor? Vendedor { get; set; }

    public long VendedorId { get; set; }
}