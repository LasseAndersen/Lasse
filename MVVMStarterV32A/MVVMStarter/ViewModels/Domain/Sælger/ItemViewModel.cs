using System;
using MVVMStarter.ViewModels.Base;
using SælgerClass = MVVMStarter.Models.Domain.Sælger.Sælger;


namespace MVVMStarter.ViewModels.Domain.Sælger
{
    public class ItemViewModel : ItemViewModelBase<SælgerClass>
    {
        // Override any of the below properties, if you wish to
        // replace the default implementation with your own
        // (the below examples contain the default implementation)
        //
        public override string Description
        {
            get { return DomainObject.ToString(); }
        }

        public override int FontSize
        {
            get { return 18; }
        }

        public override string ImageSource
        {
            get { return String.Empty; }
        }

        public override int ImageSize
        {
            get { return 80; }
        }

        public override bool ImageIsVisible
        {
            get { return true; }
        }

        public ItemViewModel(SælgerClass obj) : base(obj)
        {
        }
    }
}
