using CompiledBindingTest.Contracts;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CompiledBindingTest.ViewModels
{
    public class MyViewModel : IMyViewModel, INotifyPropertyChanged
    {
        string _MyTextProperty;
        public string MyTextProperty
        {
            get
            {
                return _MyTextProperty;
            }

            set
            {
                if(_MyTextProperty != value)
                {
                    _MyTextProperty = value;
                    OnPropertyChanged();
                }
            }
        }

        public MyViewModel()
        {
            MyTextProperty = DateTime.Now.ToString();
        }

        public void OnPropertyChanged([CallerMemberName]string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
