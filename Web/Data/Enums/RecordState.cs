namespace DNMOFT.CostTrackr.Web.Data.Enums
{
    using System.ComponentModel;

    public enum RecordState : byte
    {
        /// <summary>
        ///     The active
        /// </summary>
        [Description("Active")]
        Active = 1,

        /// <summary>
        ///     The inactive
        /// </summary>
        [Description("Inactive")]
        Inactive = 0,

        /// <summary>
        ///     The deleted
        /// </summary>
        [Description("Deleted")]
        Deleted = 2
    }
}