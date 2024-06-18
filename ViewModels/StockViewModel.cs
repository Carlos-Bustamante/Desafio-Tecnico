using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Desafio_Tecnico.Models.Entities;
using Desafio_Tecnico.Repositories.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Desafio_Tecnico.ViewModels
{
    public class StockViewModel : INotifyPropertyChanged
    {
        private readonly IStockRepository _stockRepository;
        private ObservableCollection<Stock> _stocks;
        private string _searchTerm;

        public ObservableCollection<Stock> Stocks
        {
            get { return _stocks; }
            set
            {
                _stocks = value;
                OnPropertyChanged(nameof(Stocks));
            }
        }

        public string SearchTerm
        {
            get { return _searchTerm; }
            set
            {
                _searchTerm = value;
                OnPropertyChanged(nameof(SearchTerm));
            }
        }

        public ICommand SearchCommand { get; set; }

        public StockViewModel(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
            Stocks = new ObservableCollection<Stock>();
            SearchCommand = new ViewModelCommand(async (parameter) => await SearchAsync());
            LoadData();
        }

        private async void LoadData()
        {
            var stocks = await _stockRepository.GetAll();
            Stocks = new ObservableCollection<Stock>(stocks);
        }

        private async Task SearchAsync()
        {
            var stocks = await _stockRepository.SearchAsync(SearchTerm);
            Stocks = new ObservableCollection<Stock>(stocks);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
