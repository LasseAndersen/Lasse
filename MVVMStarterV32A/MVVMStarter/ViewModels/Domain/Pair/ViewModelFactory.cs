using MVVMStarter.ViewModels.Base;
using PairClass = MVVMStarter.Models.Domain.Pair.Pair;

namespace MVVMStarter.ViewModels.Domain.Pair
{
    public class ViewModelFactory : ViewModelFactoryBase<PairClass>
    {
        public override Photo.DetailsViewModel CreateDetailsViewModel(PairClass obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ItemViewModelBase<PairClass> CreateItemViewModel(PairClass obj)
        {
            return new ItemViewModel(obj);
        }

        public override Photo.MasterViewModel CreateMasterViewModel()
        {
            return new MasterViewModel();
        }
    }
}