using Web.Data.Enums;

namespace Web.Data.Interfaces
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