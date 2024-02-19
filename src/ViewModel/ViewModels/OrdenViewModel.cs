using DNMOFT.CostTrackr.ViewModel.Base;

namespace DNMOFT.CostTrackr.ViewModel;

public class OrdenViewModel : BaseViewModel
{
    public long ClienteId { get; set; }

    public string ClienteNombre { get; set; } = string.Empty;

    public virtual ICollection<OrdenDetailsViewModel>? Details { get; set; }

    public DateTime? Entregar { get; set; }

    public string Nota { get; set; } = string.Empty;

    public string Numero { get; set; } = string.Empty;

    public string VendedorNombre { get; set; } = string.Empty;

    public long VendedorId { get; set; }
}
