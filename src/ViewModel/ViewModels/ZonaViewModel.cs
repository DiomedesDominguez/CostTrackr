using DNMOFT.CostTrackr.ViewModel.Base;

namespace DNMOFT.CostTrackr.ViewModel;

public class ZonaViewModel:BaseRegionViewModel
{
/// <summary>
    ///     Gets or sets a value indicating whether [es predefinido].
    /// </summary>
    /// <value><c>true</c> if [es predefinido]; otherwise, <c>false</c>.</value>
    public bool EsPredefinido { get; set; }

    /// <summary>
    ///     Gets or sets the municipio.
    /// </summary>
    /// <value>The municipio.</value>
    public string MunicipioNombre { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the municipio identifier.
    /// </summary>
    /// <value>The municipio identifier.</value>
    public long? MunicipioId { get; set; }


    /// <summary>
    ///     Gets or sets the provincia.
    /// </summary>
    /// <value>The provincia.</value>
    public string ProvinciaNombre { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the provincia identifier.
    /// </summary>
    /// <value>The provincia identifier.</value>
    public long? ProvinciaId { get; set; }
}
