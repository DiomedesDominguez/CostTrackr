using System.ComponentModel.DataAnnotations;
using DNMOFT.CostTrackr.ViewModel.Base;

namespace DNMOFT.CostTrackr.ViewModel;

public class ProductoFamiliaViewModel : BaseViewModel
{

    [MaxLength(200)]
    public string Descripcion { get; set; } = string.Empty;

    [Required]
    [MaxLength(30)]
    public string Nombre { get; set; } = string.Empty;
}
