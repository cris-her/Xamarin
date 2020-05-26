using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace App
{
    public abstract class NotificationObject : INotifyPropertyChanged
    {
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
