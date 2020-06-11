using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Common;
using GalaSoft.MvvmLight.CommandWpf;

namespace CodingTest
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly IFizzBuzzService _fizzBuzzService;
        private int _input;
        private IEnumerable<object> _results;
        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        public ICommand ExecuteCommand => new RelayCommand<int>(value =>
        {
            //TODO: Implement the command behavior
        });

        public int Input
        {
            get => _input;
            set
            {
                _input = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<object> Results
        {
            get => _results;
            set
            {
                _results = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
