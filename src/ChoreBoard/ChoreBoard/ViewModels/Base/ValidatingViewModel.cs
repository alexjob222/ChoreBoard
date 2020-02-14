using System;
using System.Collections.Generic;
using System.ComponentModel;
using ChoreBoard.Utility;

namespace ChoreBoard.ViewModels.Base
{
    abstract class ValidatingViewModel : BaseViewModel
    {
        private bool _isDataValid;

        public bool IsDataValid
        {
            get => _isDataValid;
            private set => SetProperty(ref _isDataValid, value);
        }

        protected abstract bool ValidateData();

        public bool UpdateIsDataValid()
        {
            IsDataValid = ValidateData();
            return IsDataValid;
        }

        protected void ValidateDataOnPropertyChanged(params INotifyPropertyChanged[] objectsToMonitor)
        {
            Ensure.ArgumentNotNull(objectsToMonitor, nameof(objectsToMonitor));

            foreach (var obj in objectsToMonitor)
            {
                if (obj is null)
                {
                    continue;
                }

                obj.PropertyChanged += ObjectToMonitor_PropertyChanged;
            }
        }

        private void ObjectToMonitor_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            UpdateIsDataValid();
        }
    }
}