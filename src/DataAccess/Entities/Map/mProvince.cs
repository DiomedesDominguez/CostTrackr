using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;

namespace DNMOFT.CostTrackr.DataAccess.Entities.Map;
[Table("mProvincias")]
public class mProvince : BaseRegion
{
    [ForeignKey("Country")]
    public long? CountryId { get; set; }
    public virtual mPais? Country { get; set; }
}