namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

/// <summary>
/// Represents a repository for managing clients.
/// </summary>
public class ClienteRepository: BaseRepository<mCliente>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClienteRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public ClienteRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}