using MVVMStarter.Validators.App;
using MVVMStarter.ViewModels.Base;
using SælgerClass = MVVMStarter.Models.Domain.Sælger.Sælger;

namespace MVVMStarter.ViewModels.Domain.sælger
{
    public class DetailsViewModel : DetailsViewModelBase<SælgerClass>
    {
        //// Template for validated property (may throw ValidationException) 
        //public string MyValidatedProperty
        //{
        //    get { return DomainObject.MyValidatedProperty; }
        //    set
        //    {
        //        var orgValue = DomainObject.MyValidatedProperty;
        //        try
        //        {
        //            DomainObject.MyValidatedProperty = value;
        //        }
        //        catch (ValidationException e)
        //        {
        //            PresentValidationError(e.Message, () => { MyValidatedProperty = orgValue; });
        //        }
        //        OnPropertyChanged();
        //    }
        //}

        //// Template for non-validated property
        //public string MyNonValidatedProperty
        //{
        //    get { return DomainObject.MyNonValidatedProperty; }
        //    set
        //    {
        //        DomainObject.MyNonValidatedProperty = value;
        //        OnPropertyChanged();
        //    }
        //}

        public DetailsViewModel(SælgerClass obj) : base(obj)
        {
        }
    }
}
