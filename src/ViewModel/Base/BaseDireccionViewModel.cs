namespace DNMOFT.CostTrackr.ViewModel.Base;

public class BaseDireccionViewModel: BaseViewModel
{
 /// <summary>
    /// Gets or sets the address.
    /// </summary>
    public string Direccion { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the reference for the address.
    /// </summary>
    public string Referencia { get; set; } = string.Empty;

    public decimal CoordenadasX { get; set; }
    public decimal CoordenadasY { get; set; }
}
