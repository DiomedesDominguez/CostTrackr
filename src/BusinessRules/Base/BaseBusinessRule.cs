using DNMOFT.CostTrackr.BusinessRules.Interfaces;
using DNMOFT.CostTrackr.DataAccess.Interfaces;
using DNMOFT.CostTrackr.Repositories.Interfaces;
using DNMOFT.CostTrackr.ViewModel.Base;
using DNMOFT.CostTrackr.ViewModel.Interfaces;

namespace DNMOFT.CostTrackr.BusinessRules.Base;

public class BaseBusinessRule<TR, TE, TV> : IBusinessRule<TR, TE, TV>
    where TR : class, IRepository<TE>
    where TE : class, IBaseEntity, new()
    where TV : class, IBaseViewModel, new()
{
     internal TR Repository { get; set; }
     
    public OptionsViewModel Combo(long id)
    {
        throw new NotImplementedException();
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
