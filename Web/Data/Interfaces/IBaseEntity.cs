using System;
using DNMOFT.CostTrackr.Web.Data.Enums;

namespace DNMOFT.CostTrackr.Web.Data.Interfaces
{
    public interface IBaseEntity: IDisposable
    {
        string ClientIp { get; set; }
        DateTime Created { get; set; }
        long CreatedBy { get; set; }
        RecordState RecordState { get; set; }
        long Id { get; set; }
        DateTime LastUpdated { get; set; }
        long LastUpdatedBy { get; set; }
    }
}