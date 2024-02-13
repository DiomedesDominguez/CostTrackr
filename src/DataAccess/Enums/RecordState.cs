namespace DNMOFT.CostTrackr.DataAccess.Enums;
using System.ComponentModel;
public enum RecordState
{
    [Description("Activo")]
    Activo = 1,

    [Description("Inactivo")]
    Inactivo = 2,

    [Description("Eliminado")]
    Eliminado = 3
}