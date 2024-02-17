using System.ComponentModel.DataAnnotations;

namespace DNMOFT.CostTrackr.ViewModel;

public class TipoProveedorViewModel
{
    [MaxLength(120)]
    public string Descripcion { get; set; } = string.Empty;

    [Required]
    [MaxLength(30)]
    public string Nombre { get; set; } = string.Empty;
}
