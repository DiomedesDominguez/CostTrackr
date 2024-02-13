using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;

namespace DNMOFT.CostTrackr.DataAccess.Entities.Map;
[Table("mMunicipios")]
public class mMunicipality : BaseRegion
{
    [ForeignKey("Province")]
    public long? ProvinceId { get; set; }
    public virtual mProvince? Province { get; set; }
}