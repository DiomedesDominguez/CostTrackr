using System.Linq.Expressions;
using DNMOFT.CostTrackr.BusinessRules.Interfaces;
using DNMOFT.CostTrackr.DataAccess.Interfaces;
using DNMOFT.CostTrackr.Repositories.Interfaces;
using DNMOFT.CostTrackr.ViewModel.Base;
using DNMOFT.CostTrackr.ViewModel.Interfaces;
using LinqKit;

namespace DNMOFT.CostTrackr.BusinessRules.Base;

public class BaseBusinessRule<TR, TE, TV> : IBusinessRule<TR, TE, TV>
    where TR : class, IRepository<TE>
    where TE : class, IBaseEntity, new()
    where TV : class, IBaseViewModel, new()
{
    internal TR Repository { get; set; } = default!;
    internal Expression<Func<TE, bool>> Predicate { get; set; }

    public BaseBusinessRule()
    {
        Predicate = PredicateBuilder.New<TE>(x => x.RecordState != DataAccess.Enums.RecordState.Eliminado);
    }

    public OptionsViewModel Combo(long? id)
    {
        throw new NotImplementedException();
    }

    private IEnumerable<TE> Get(Expression<Func<TE, bool>>? predicate = null, int maximumRows = 0,
           int startRowIndex = 0, string? sortExpression = null, Func<TE, TE>? selector = null)
    {
        predicate = predicate == null ? Predicate : predicate.And(Predicate);

        return selector != null
            ? Repository.Get(predicate, maximumRows, startRowIndex, sortExpression).Select(selector)
            : Repository.Get(predicate, maximumRows, startRowIndex, sortExpression);
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public JTableResultViewModel<TV> Eliminar(TV iviewModeld)
    {
        throw new NotImplementedException();
    }

    public JTableResultViewModel<TV> EliminarBulk(IEnumerable<TV> viewModels)
    {
        throw new NotImplementedException();
    }

    public JTableResultViewModel<TV> Guardar(TV viewModel)
    {
        throw new NotImplementedException();
    }

    public JTableResultsViewModel<TV> GuardarBulk(IEnumerable<TV> viewModels)
    {
        throw new NotImplementedException();
    }

    public JTableResultsViewModel<TV> Listar(JTableRequestViewModel request)
    {
        throw new NotImplementedException();
    }
}
