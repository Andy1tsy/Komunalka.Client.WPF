using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Komunalka.Client.WPF.Common
{
    public class BindingBase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public BindingBase()
        {
            PropertyChanged += (sender, e) => { };
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
