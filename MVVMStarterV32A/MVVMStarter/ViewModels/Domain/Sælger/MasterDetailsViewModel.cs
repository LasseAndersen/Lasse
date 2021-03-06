﻿using System.Collections.Generic;
using MVVMStarter.ViewModels.App;
using MVVMStarter.ViewModels.Base;
using SælgerClass = MVVMStarter.Models.Domain.Sælger.Sælger;


namespace MVVMStarter.ViewModels.Domain.Sælger
{
    public class MasterDetailsViewModel : MasterDetailsViewModelBase<SælgerClass>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), Models.Domain.Bil.DomainModel.Instance)
        {
            //// Use the below code as a template for setting up default
            //// behavior for your GUI controls

            List<string> fixedProperties = new List<string>();
            // Add names of "fixed" (cannot be changed after creation) properties here
            fixedProperties.Add(nameof(SælgerClass.FixedPropertyA));
            fixedProperties.Add(nameof(SælgerClass.FixedPropertyB));
            fixedProperties.Add(nameof(SælgerClass.FixedPropertyC));

            List<string> nonFixedKeyProperties = new List<string>();
            // Add names of "non-fixed" (can be changed after creation) properties here
            nonFixedKeyProperties.Add(nameof(SælgerClass.NonFixedPropertyA));
            nonFixedKeyProperties.Add(nameof(SælgerClass.NonFixedPropertyB));

            StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonFixedKeyProperties);
            StateManager.AddButtonDefaultStates();
        }
    }
}
