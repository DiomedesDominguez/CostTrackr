namespace DNMOFT.CostTrackr.DataAccess.Interfaces;
using NetTopologySuite.Geometries;

/// <summary>
/// Represents an interface for a region.
/// </summary>
public interface IRegion : IDisposable
{
    /// <summary>
    /// Gets or sets the coordinates of the region.
    /// </summary>
    MultiPolygon? Coordenadas { get; set; }
}