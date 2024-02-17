using System.ComponentModel.DataAnnotations;
using DNMOFT.CostTrackr.ViewModel.Base;

namespace DNMOFT.CostTrackr.ViewModel;

public class VendedorViewModel:BaseViewModel
{
[MaxLength(19)]
    public string Codigo { get; set; } = string.Empty;

    [MaxLength(120)]
    public string Direccion { get; set; } = string.Empty;

    [Required]
    [MaxLength(23)]
    [MinLength(8)]
    public string Documento { get; set; } = string.Empty;

    [MaxLength(75)]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    [MinLength(3)]
    public string Nombre { get; set; } = string.Empty;

    public string Telefono1 { get; set; } = string.Empty;
    public string Telefono2 { get; set; } = string.Empty;
    public string Telefono3 { get; set; } = string.Empty;

    [Required]
    public string TipoDocumentoNombre { get; set; } = string.Empty;
}
