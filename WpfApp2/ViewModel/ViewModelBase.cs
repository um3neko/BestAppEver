using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.ViewModel
{
  
        public abstract class ViewModelBase : INotifyPropertyChanged
        {

            public event PropertyChangedEventHandler PropertyChanged;
            //[CallerMemberName]
            //Можно вызывать не указывая имя свойства, комп автоматом подставит имя метода, из которого оно вызывается.
            protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
            }

            protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
            {
                if (Equals(field, value)) return false;
                field = value;
                OnPropertyChanged(PropertyName);
                return true;
            }
        }
    
}
