using System.Collections.Generic;
using MVVMStarter.ViewModels.App;
using MVVMStarter.ViewModels.Base;
using KundeClass = MVVMStarter.Models.Domain.Kunde.Kunde;


namespace MVVMStarter.ViewModels.Domain.Kunde
{
    public class MasterDetailsViewModel : MasterDetailsViewModelBase<KundeClass>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), Models.Domain.Bil.DomainModel.Instance)
        {
            //// Use the below code as a template for setting up default
            //// behavior for your GUI controls

            List<string> fixedProperties = new List<string>();
            // Add names of "fixed" (cannot be changed after creation) properties here
            fixedProperties.Add(nameof(KundeClass.FixedPropertyA));
            fixedProperties.Add(nameof(KundeClass.FixedPropertyB));
            fixedProperties.Add(nameof(KundeClass.FixedPropertyC));

            List<string> nonFixedKeyProperties = new List<string>();
            // Add names of "non-fixed" (can be changed after creation) properties here
            nonFixedKeyProperties.Add(nameof(KundeClass.NonFixedPropertyA));
            nonFixedKeyProperties.Add(nameof(KundeClass.NonFixedPropertyB));

            StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonFixedKeyProperties);
            StateManager.AddButtonDefaultStates();
        }
    }
}
