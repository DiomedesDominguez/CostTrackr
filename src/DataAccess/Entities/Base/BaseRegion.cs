using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Interfaces;
using NetTopologySuite.Geometries;

namespace DNMOFT.CostTrackr.DataAccess.Entities.Base;

/// <summary>
/// Represents a base region entity.
/// </summary>
public class BaseRegion : BaseEntity, IRegion
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
    [Column(TypeName="geography")]
    public MultiPolygon? Coordenadas { get; set; }

    /// <summary>
    /// Gets or sets the type of the region.
    /// </summary>
    public string Tipo { get; set; } = string.Empty;
}

