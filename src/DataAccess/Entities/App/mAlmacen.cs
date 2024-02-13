using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;
using DNMOFT.CostTrackr.DataAccess.Entities.Map;

namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
/// <summary>
///     Class mAlmacenes.
/// </summary>
[Table("mAlmacenes")]
public class mAlmacen : BaseDireccion
{
    #region Fields and properties

    public virtual mMunicipality? Municipio { get; set; }

    [ForeignKey("Municipio")]
    public long MunicipioId { get; set; }

    /// <summary>
    ///     Gets or sets the codigo.
    /// </summary>
    /// <value>The codigo.</value>
    [MaxLength(19)]
    public string Codigo { get; set; } = "";

    /// <summary>
    ///     Gets or sets the descripcion.
    /// </summary>
    /// <value>The descripcion.</value>
    [MaxLength(200)]
    public string Descripcion { get; set; } = "";

    /// <summary>
    ///     Gets or sets the nombre.
    /// </summary>
    /// <value>The nombre.</value>
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Nombre { get; set; } = "";

    #endregion

}