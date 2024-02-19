using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Interfaces;
using NetTopologySuite.Geometries;

namespace DNMOFT.CostTrackr.DataAccess.Entities.Base;
/// <summary>
/// Represents a base class for addresses in the system.
/// </summary>
public class BaseDireccion : BaseEntity, IDireccion
{
    /// <summary>
    /// Gets or sets the address.
    /// </summary>
    public string Direccion { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the reference for the address.
    /// </summary>
    public string Referencia { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the coordinates of the address.
    /// </summary>
    [Column(TypeName="geography")]
    public Point? Coordenadas { get; set; }
}