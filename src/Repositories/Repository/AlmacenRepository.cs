using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;
/// <summary>
/// Represents a repository for managing Almacen entities.
/// </summary>
public class AlmacenRepository : BaseRepository<mAlmacen>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AlmacenRepository"/> class.
    /// </summary>
    /// <param name="context">The application database context.</param>
    public AlmacenRepository(ApplicationDbContext context)
        : base(context)
    {
    }
}
