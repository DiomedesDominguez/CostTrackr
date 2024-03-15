using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.Identity;

namespace DNMOFT.CostTrackr.Web.Helpers;
public static class SeedData
{
    public static async Task Initialize(ApplicationDbContext context)
    {
        if (!context.Users.Any())
        {        
            // Add the admin user
            context.Users.Add(
                new mUser
                {
                    ConcurrencyStamp = "a26629bd-7a95-4081-93ac-5db15e2e6ca7",
                    Email = "diomedes.dominguez@gmail.com",
                    NormalizedEmail = "DIOMEDES.DOMINGUEZ@GMAIL.COM",
                    NormalizedUserName = "DIOMEDES.DOMINGUEZ@GMAIL.COM",
                    PasswordHash = "AQAAAAIAAYagAAAAEEzyZoMD5vGu/12w6IsMsJsS9XEH5H+mouzt7BMnMUG3feLTsnAsmlvKsPPkfXlCcA==",
                    PhoneNumber = "",
                    SecurityStamp="YCOFX3N6QRHS7F25TL5EMV4EBYQLUJN3",
                    UserName = "diomedes.dominguez@gmail.com",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    TwoFactorEnabled = false,
                    AccessFailedCount = 0,
                    Name = "Diomedes",
                    LastName = "Dominguez",
                    Created = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    CreatedBy = 1,
                    LastUpdatedBy = 1,
                }                    

            );
            await context.SaveChangesAsync();
        }
    }
}