using System.Collections.Generic;
using MVVMStarter.ViewModels.App;
using MVVMStarter.ViewModels.Base;
using BilClass = MVVMStarter.Models.Domain.Bil.Bil;


namespace MVVMStarter.ViewModels.Domain.Bil
{
    public class MasterDetailsViewModel : MasterDetailsViewModelBase<BilClass>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), Models.Domain.Bil.DomainModel.Instance)
        {
            //// Use the below code as a template for setting up default
            //// behavior for your GUI controls

            List<string> fixedProperties = new List<string>();
            // Add names of "fixed" (cannot be changed after creation) properties here
            fixedProperties.Add(nameof(BilClass.FixedPropertyA));
            fixedProperties.Add(nameof(BilClass.FixedPropertyB));
            fixedProperties.Add(nameof(BilClass.FixedPropertyC));

            List<string> nonFixedKeyProperties = new List<string>();
            // Add names of "non-fixed" (can be changed after creation) properties here
            nonFixedKeyProperties.Add(nameof(BilClass.NonFixedPropertyA));
            nonFixedKeyProperties.Add(nameof(BilClass.NonFixedPropertyB));

            StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonFixedKeyProperties);
            StateManager.AddButtonDefaultStates();
        }
    }
}
