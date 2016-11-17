using CompiledBindingTest.Contracts;
using CompiledBindingTest.ViewModels;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CompiledBindingTest
{
    public sealed partial class MainPage : Page
    {
        public IMyViewModel ViewModel { get; set; } = new MyViewModel();
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.MyTextProperty = DateTime.Now.ToString();
        }
    }
}
