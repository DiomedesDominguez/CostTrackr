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
        public override string ClaimType { get; set; }  
        [Column(TypeName = "text")]
        public override string ClaimValue { get; set; } 

        [MaxLength(15), Column(TypeName = "varchar(15)")]
        [Required, DefaultValue("'127.0.0.1'")]
        public string ClientIp { get; set; } 

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created { get; set; }
        [DefaultValue(1)]
        public long CreatedBy { get; set; }
        public RecordState RecordState { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }
        [DefaultValue(1)]
        public long LastUpdatedBy { get; set; }
    }
}