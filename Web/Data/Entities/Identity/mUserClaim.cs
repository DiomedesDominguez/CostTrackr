using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DNMOFT.CostTrackR.Web.Data.Enums;
using Microsoft.AspNetCore.Identity;

namespace DNMOFT.CostTrackR.Web.Data.Entities.Identity
{
    [Table("mUserClaims")]
    public class mUserClaim: IdentityUserClaim<long>
    {
         [Column(TypeName = "text")]
#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override string ClaimType { get; set; }  
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        [Column(TypeName = "text")]
#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override string ClaimValue { get; set; } 
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).

        [MaxLength(15), Column(TypeName = "varchar(15)")]
        [Required, DefaultValue("'127.0.0.1'")]
        public string ClientIp { get; set; } 

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created { get; set; }
        [DefaultValue(1)]
        public long CreatedBy { get; set; }
        [DefaultValue(1)]
        public RecordState RecordState { get; set; } = RecordState.Active;
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }
        [DefaultValue(1)]
        public long LastUpdatedBy { get; set; }

        public mUserClaim()
        {
            ClaimType = string.Empty;
        }
    }
}