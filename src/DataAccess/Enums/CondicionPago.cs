using System.ComponentModel;

namespace DNMOFT.CostTrackr.DataAccess.Enums;
/// <summary>
/// Represents the payment conditions for a transaction.
/// </summary>
public enum CondicionPago : byte
{
    /// <summary>
    /// Payment is made immediately.
    /// </summary>
    [Description("Contado")] P0 = 0,
    
    /// <summary>
    /// Payment is due within 5 days.
    /// </summary>
    [Description("5 DÍAS")] P5 = 1,
    
    /// <summary>
    /// Payment is due within 15 days.
    /// </summary>
    [Description("15 DÍAS")] P15 = 2,
    
    /// <summary>
    /// Payment is due within 30 days.
    /// </summary>
    [Description("30 DÍAS")] P30 = 3,
    
    /// <summary>
    /// Payment is due within 45 days.
    /// </summary>
    [Description("45 DÍAS")] P45 = 4,
    
    /// <summary>
    /// Payment is due within 60 days.
    /// </summary>
    [Description("60 DÍAS")] P60 = 5
}