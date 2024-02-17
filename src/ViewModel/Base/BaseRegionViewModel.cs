using System.ComponentModel.DataAnnotations;

namespace DNMOFT.CostTrackr.ViewModel.Base;

public class BaseRegionViewModel: BaseViewModel
{
/// <summary>
    /// Gets or sets the name of the region.
    /// </summary>
    [Required]
    [MaxLength(300)]
    public string Nombre { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the code of the region.
    /// </summary>
    [Required]
    public string Codigo { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the coordinates of the region.
    /// </summary>
    public List<PuntoViewModel>? Coordenadas { get; set; }

    /// <summary>
    /// Gets or sets the type of the region.
    /// </summary>
    public string Tipo { get; set; } = string.Empty;
}
