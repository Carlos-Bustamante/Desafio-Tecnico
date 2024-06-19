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
using Desafio_Tecnico.Models;
using Desafio_Tecnico.Repositories;

namespace Desafio_Tecnico.ViewModels
{
    public class StockViewModel : ViewModelBase
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
        // Constructor sin parámetros para uso en XAML
        public StockViewModel() : this(new StockRepository(new TestContext())) { }

        public StockViewModel(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
            Stocks = new ObservableCollection<Stock>();
            SearchCommand = new ViewModelCommand(async (parameter) => await SearchAsync());
            LoadData();
        }

        private async Task LoadData()
        {
            var stocks = await _stockRepository.GetAll();
            Stocks = new ObservableCollection<Stock>(stocks);
        }

        private async Task SearchAsync()
        {
            var stocks = await _stockRepository.SearchAsync(SearchTerm);
            Stocks = new ObservableCollection<Stock>(stocks);
        }
    }

}
