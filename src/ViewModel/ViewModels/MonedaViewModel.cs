using DNMOFT.CostTrackr.ViewModel.Base;

namespace DNMOFT.CostTrackr.ViewModel;

public class MonedaViewModel : BaseViewModel
{
    public string Nombre { get; set; } = string.Empty;
    public string Simbolo { get; set; } = string.Empty;
    public string ISO { get; set; } = string.Empty;
    public bool EsPrimaria { get; set; }
    public decimal Tasa { get; set; }
}
