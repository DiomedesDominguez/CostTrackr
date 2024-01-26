namespace DNMOFT.CostTrackR.Web.Data.Entities.Identity
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using DNMOFT.CostTrackR.Web.Data.Enums;
    using Microsoft.AspNetCore.Identity;
    [Table("mRoleClaims")]
    public class mRoleClaim: IdentityRoleClaim<long>
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
        [DefaultValue("'127.0.0.1'"), Required]
        public string ClientIp { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created { get; set; }

        [Required, DefaultValue(1)]
        public long CreatedBy { get; set; }
        public RecordState RecordState { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }

        [Required, DefaultValue(1)]
        public long LastUpdatedBy { get; set; }
    }
}