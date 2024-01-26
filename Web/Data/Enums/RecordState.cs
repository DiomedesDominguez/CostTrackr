namespace Web.Data.Enums
{
     using System.ComponentModel;

/// <summary>
/// Estado del registro o fila de una tabla. Estos pueden ser activos, inactivos o borrados.
/// </summary>
    public enum RecordState : byte
    {
        /// <summary>
        ///    Estado activo del registro.
        /// </summary>
        [Description("Activo")]
        Active = 1,
/// <summary>
///   Estado inactivo del registro.
/// </summary>
        [Description("Inactivo")]
        Inactive = 0,
/// <summary>
///  Estado borrado del registro.
/// </summary>
        [Description("Borrado")]
        Deleted = 2
    }
}