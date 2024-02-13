using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;

namespace DNMOFT.CostTrackr.DataAccess.Entities.Map;
[Table("mPaises")]
public class mPais : BaseRegion
{
    public virtual ICollection<mProvince> Provincias { get; set; }

    public mPais()
    {
        Provincias = new HashSet<mProvince>();
    }
}