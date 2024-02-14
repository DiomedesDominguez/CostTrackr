using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;

/// <summary>
/// Represents a repository for managing Vendedor entities.
/// </summary>
public class VendedorRepository : BaseRepository<mVendedor>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VendedorRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public VendedorRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
