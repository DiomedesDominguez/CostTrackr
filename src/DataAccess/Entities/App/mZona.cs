namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;
using DNMOFT.CostTrackr.DataAccess.Entities.Map;

[Table("mZonas")]
public class mZona : BaseRegion
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
    public virtual mMunicipality? Municipio { get; set; }

    /// <summary>
    ///     Gets or sets the municipio identifier.
    /// </summary>
    /// <value>The municipio identifier.</value>
    public long? MunicipioId { get; set; }


    /// <summary>
    ///     Gets or sets the provincia.
    /// </summary>
    /// <value>The provincia.</value>
    public virtual mProvince? Provincia { get; set; }

    /// <summary>
    ///     Gets or sets the provincia identifier.
    /// </summary>
    /// <value>The provincia identifier.</value>
    public long? ProvinciaId { get; set; }

}