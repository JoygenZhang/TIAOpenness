using System.Diagnostics;
using Prism.Commands;
using Prism.Mvvm;

namespace TIAOpenness.ViewModels
{
    public class MainWindow1ViewModel : BindableBase

    {
        private string _hello;

        public string Hello
        {
            get => _hello;
            set => SetProperty(ref _hello, value);
        }

        private DelegateCommand _nameClick;

        public DelegateCommand NameClick =>
            _nameClick ?? (_nameClick = new DelegateCommand(ExecuteNameClick));

        void ExecuteNameClick()
        {
        }

        private DelegateCommand _clickCommand;

        public DelegateCommand ClickCommand =>
            _clickCommand ?? (_clickCommand = new DelegateCommand(ExecuteClickCommand));

        void ExecuteClickCommand()
        {
            Debug.Print("Hello");
        }
    }
}