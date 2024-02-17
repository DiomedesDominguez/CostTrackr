using System.ComponentModel.DataAnnotations;
using DNMOFT.CostTrackr.ViewModel.Base;

namespace DNMOFT.CostTrackr.ViewModel;

public class SucursalViewModel : BaseViewModel
{
    [MaxLength(100)]
    public string Descripcion { get; set; } = string.Empty;

    [Required]
    [StringLength(30, MinimumLength = 3)]
    public string Nombre { get; set; } = string.Empty;
}
