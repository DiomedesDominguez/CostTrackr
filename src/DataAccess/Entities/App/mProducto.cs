namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;
using DNMOFT.CostTrackr.DataAccess.Enums;

[Table("mProductos")]
public class mProducto : BaseEntity
{
    public bool AplicaImpuesto { get; set; }

    public bool AplicaOferta { get; set; }

    public string Codigo { get; set; } = string.Empty;

    public string ContabilidadId { get; set; } = string.Empty;

    public string CuentaContable { get; set; } = string.Empty;

    public string Descripcion { get; set; } = string.Empty;

    public string DescripcionContabilidad { get; set; } = string.Empty;

    public virtual mImpuesto? Impuesto { get; set; }

    public long? ImpuestoId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nombre { get; set; } = string.Empty;

    [Required]
    [Range(0, double.MaxValue)]
    public decimal Precio { get; set; }

    public virtual mPresentacion? Presentacion { get; set; }

    public long PresentacionId { get; set; }

    public virtual mProductoFamilia? ProductoFamilia { get; set; }

    public long? ProductoFamiliaId { get; set; }
}