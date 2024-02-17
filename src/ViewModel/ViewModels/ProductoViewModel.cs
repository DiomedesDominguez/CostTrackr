using DNMOFT.CostTrackr.ViewModel.Base;

namespace DNMOFT.CostTrackr.ViewModel;

public class ProductoViewModel : BaseViewModel
{
    public bool AplicaImpuesto { get; set; }

    public bool AplicaOferta { get; set; }

    public string Codigo { get; set; } = string.Empty;

    public string ContabilidadId { get; set; } = string.Empty;

    public string CuentaContable { get; set; } = string.Empty;

    public string Descripcion { get; set; } = string.Empty;

    public string DescripcionContabilidad { get; set; } = string.Empty;

    public string ImpuestoNombre { get; set; }

    public long? ImpuestoId { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public decimal Precio { get; set; }

    public string PresentacionNombre { get; set; }

    public long PresentacionId { get; set; }

    public string ProductoFamiliaNombre { get; set; }

    public long? ProductoFamiliaId { get; set; }
}
