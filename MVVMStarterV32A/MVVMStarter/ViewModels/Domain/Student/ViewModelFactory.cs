using MVVMStarter.ViewModels.Base;
using StudentClass = MVVMStarter.Models.Domain.Student.Student;

namespace MVVMStarter.ViewModels.Domain.Student
{
    public class ViewModelFactory : ViewModelFactoryBase<StudentClass>
    {
        public override Photo.DetailsViewModel CreateDetailsViewModel(StudentClass obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ItemViewModelBase<StudentClass> CreateItemViewModel(StudentClass obj)
        {
            return new ItemViewModel(obj);
        }

        public override Photo.MasterViewModel CreateMasterViewModel()
        {
            return new MasterViewModel();
        }
    }
}
