using DNMOFT.CostTrackr.DataAccess.Interfaces;
using DNMOFT.CostTrackr.Repositories.Interfaces;
using DNMOFT.CostTrackr.ViewModel.Base;
using DNMOFT.CostTrackr.ViewModel.Interfaces;

namespace DNMOFT.CostTrackr.BusinessRules.Interfaces
{
    public interface IBusinessRule<TR, TE, TV> : IDisposable
         where TR : class, IRepository<TE>
         where TE : class, IBaseEntity, new()
         where TV : class, IBaseViewModel, new()
    {
        OptionsViewModel Combo(long id);
        JTableResultViewModel<TV> Guardar(TV viewModel);
        JTableResultsViewModel<TV> GuardarBulk(IEnumerable<TV> viewModels);
        JTableResultsViewModel<TV> Listar(JTableRequestViewModel request);
        JTableResultViewModel<TV> Eliminar(TV iviewModeld);
        JTableResultViewModel<TV> EliminarBulk(IEnumerable<TV> viewModels);
    }
}