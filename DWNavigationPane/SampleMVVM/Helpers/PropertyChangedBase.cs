using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SampleMVVM.Helpers
{
    internal abstract class PropertyChangedBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void Refresh()
        {
            this.NotifyOfPropertyChange(String.Empty);
        }

        protected virtual void NotifyOfPropertyChange([CallerMemberName] string propertyName = "")
        {
            this.OnPropertyChanged(propertyName);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                var handler = this.PropertyChanged;
                if (handler != null)
                    handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected virtual bool SetAndNotify<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                this.NotifyOfPropertyChange(propertyName: propertyName);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}