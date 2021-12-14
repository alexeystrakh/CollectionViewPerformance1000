using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CollectionViewPerfXamarin.ViewModels
{
    public class NotifyPropertyChangedBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool RaiseAndUpdate<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;

            field = value;
            Raise(propertyName);

            return true;
        }

        protected bool RaiseAndUpdate(Func<bool> shouldRaiseFunc, Action updateFieldAction, [CallerMemberName] string propertyName = null)
        {
            if (!shouldRaiseFunc())
                return false;

            updateFieldAction();
            Raise(propertyName);

            return true;
        }

        protected void Raise(string propertyName)
        {
            if (!string.IsNullOrEmpty(propertyName) && PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}