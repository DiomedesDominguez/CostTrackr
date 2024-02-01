using System.ComponentModel;

namespace Web.Data.Enums
{
    public enum TipoDocumento : byte
    {
        /// <summary>
        /// The cedula
        /// </summary>
        [Description("Cédula")]
        Cedula = 1,
        /// <summary>
        /// The RNC
        /// </summary>
        [Description("RNC")]
        Rnc = 2,
        /// <summary>
        /// The pasaporte
        /// </summary>
        [Description("Pasaporte")]
        Pasaporte = 3,
        /// <summary>
        /// The otro
        /// </summary>
        [Description("Otro")]
        Otro = 4
    }
}