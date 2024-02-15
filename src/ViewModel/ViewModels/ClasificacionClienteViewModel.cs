using System.ComponentModel.DataAnnotations;
using DNMOFT.CostTrackr.ViewModel.Base;

namespace DNMOFT.CostTrackr.ViewModel;

public class ClasificacionClienteViewModel : BaseViewModel
{
    [MaxLength(15)]
    public string Codigo { get; set; } = string.Empty;

    [MaxLength(550)]
    public string Descripcion { get; set; } = string.Empty;

    [Required]
    [StringLength(40, MinimumLength = 3)]
    public string Nombre { get; set; } = string.Empty;
}
