using System.ComponentModel;

namespace CompiledBindingTest.Contracts
{
    public interface IMyViewModel 
        //: INotifyPropertyChanged
        //just uncomment the above line, clean year project and run again to make compiled bindings work
    {
        string MyTextProperty { get; set; }
    }
}
