using NetTopologySuite.Geometries;

namespace DNMOFT.CostTrackr.DataAccess.Interfaces;
/// <summary>
/// Represents an interface for a direccion (address) entity.
/// </summary>
public interface IDireccion : IDisposable
{
    /// <summary>
    /// /// Gets or sets the address.
    /// </summary>
    string Direccion { get; set; }

    /// <summary>
    /// Gets or sets the reference for the address.
    /// </summary>
    string Referencia { get; set; }

    /// <summary>
    /// Gets or sets the coordinates of the address.
    /// </summary>
    Point? Coordenadas { get; set; }
}