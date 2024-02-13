using System.ComponentModel;

namespace DNMOFT.CostTrackr.DataAccess.Enums;
/// <summary>
/// Represents the types of documents.
/// </summary>
public enum TipoDocumento
{
    /// <summary>
    /// Cédula document type.
    /// </summary>
    [Description("Cédula")]
    Cedula = 1,

    /// <summary>
    /// RNC document type.
    /// </summary>
    [Description("RNC")]
    Rnc = 2,

    /// <summary>
    /// Pasaporte document type.
    /// </summary>
    [Description("Pasaporte")]
    Pasaporte = 3,

    /// <summary>
    /// Other document type.
    /// </summary>
    [Description("Otro")]
    Otro = 4
}