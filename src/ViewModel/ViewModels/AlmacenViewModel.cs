using System.ComponentModel.DataAnnotations;
using DNMOFT.CostTrackr.ViewModel.Base;

namespace DNMOFT.CostTrackr.ViewModel;

public class AlmacenViewModel : BaseViewModel
{
    public long MunicipioId { get; set; }
    public string MunicipioNombre { get; set; } = string.Empty;
    [MaxLength(19)]
    public string Codigo { get; set; } = string.Empty;
    [MaxLength(200)]
    public string Descripcion { get; set; } = string.Empty;
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Nombre { get; set; } = string.Empty;
}
