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
    [Table("mUsersRoles")]
    public class mUserRole: IdentityUserRole<long>
    {
        [MaxLength(15), Column(TypeName = "varchar(15)")]
        [Required, DefaultValue("'127.0.0.1'")]
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string ClientIp { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created { get; set; }
        public long CreatedBy { get; set; }
        public RecordState RecordState { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }
        [DefaultValue(1)]
        public long LastUpdatedBy { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public long Id { get; set; }
    }
}