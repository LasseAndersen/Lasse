using MVVMStarter.Models.Base;
using MVVMStarter.ViewModels.Domain.Photo;

namespace MVVMStarter.ViewModels.Base
{
    public abstract class ViewModelFactoryBase<TDomainClass>
        where TDomainClass : DomainClassBase
    {
        public abstract DetailsViewModel CreateDetailsViewModel(TDomainClass obj);
        public abstract ItemViewModelBase<TDomainClass> CreateItemViewModel(TDomainClass obj);
        public abstract MasterViewModel CreateMasterViewModel();
    }
}
