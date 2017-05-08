using MVVMStarter.Validators.App;
using MVVMStarter.ViewModels.Base;
using BilClass = MVVMStarter.Models.Domain.Bil.Bil;

namespace MVVMStarter.ViewModels.Domain.Bil
{
    public class DetailsViewModel : DetailsViewModelBase<BilClass>
    {
        // Template for validated property (may throw ValidationException) 
        public string MyValidatedProperty
        {
            get { return DomainObject.MyValidatedProperty; }
            set
            {
                var orgValue = DomainObject.MyValidatedProperty;
                try
                {
                    DomainObject.MyValidatedProperty = value;
                }
                catch (ValidationException e)
                {
                    PresentValidationError(e.Message, () => { MyValidatedProperty = orgValue; });
                }
                OnPropertyChanged();
            }
        }

        // Template for non-validated property
        public string MyNonValidatedProperty
        {
            get { return DomainObject.MyNonValidatedProperty; }
            set
            {
                DomainObject.MyNonValidatedProperty = value;
                OnPropertyChanged();
            }
        }

        public DetailsViewModel(BilClass obj) : base(obj)
        {
        }
    }
}
