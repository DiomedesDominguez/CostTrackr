using DNMOFT.CostTrackr.ViewModel.Base;

namespace DNMOFT.CostTrackr.ViewModel;

public class PresentacionViewModel : BaseViewModel
{
    public decimal Alto { get; set; }
    public decimal Ancho { get; set; }

    public short Cantidad { get; set; }

    public string Descripcion { get; set; } = string.Empty;
    public decimal Largo { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public decimal Peso { get; set; }
    public decimal TotalDimension => Alto * Ancho * Largo;
}
