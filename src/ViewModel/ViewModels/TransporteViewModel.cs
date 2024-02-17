using System.ComponentModel.DataAnnotations;
using DNMOFT.CostTrackr.ViewModel.Base;

namespace DNMOFT.CostTrackr.ViewModel;

public class TransporteViewModel : BaseViewModel
{
    public decimal Alto { get; set; }

    [Required]
    public decimal Ancho { get; set; }

    [Required]
    public decimal Capacidad { get; set; }

    public decimal Dimension => Largo * Ancho * Alto;

    [Required]
    public decimal Largo { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nombre { get; set; } = string.Empty;
}
