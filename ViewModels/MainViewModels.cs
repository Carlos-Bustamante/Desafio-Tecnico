using Desafio_Tecnico.Models;
using Desafio_Tecnico.Repositories;
using Desafio_Tecnico.Repositories.Interfaces;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Desafio_Tecnico.ViewModels
{
    public class MainViewModels: ViewModelBase{

        private TestContext testContext = new TestContext();

        private ViewModelBase _currentChildView;
        private string _caption;
        private IconChar _icon;

        public ViewModelBase CurrentChildView { 
            get { return _currentChildView; }  
            set {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            } 
        }
        public string Caption { 
            get { return _caption; }  
            set { _caption = value;
                OnPropertyChanged(nameof(Caption));
            }  
        }
        public IconChar Icon { 
            get { return _icon; }  
            set { _icon = value;
                  OnPropertyChanged(nameof(Icon));
            }  
        }

        //command
        public ICommand ShowHomeViewCommand { get; }
        public ICommand ShowStockViewCommand { get; }
        public ICommand ShowProductsViewCommand { get; }

        public MainViewModels(){

            //Init with command
            ShowHomeViewCommand = new ViewModelCommand(ExecuteShowHomeViewCommand);
            ShowStockViewCommand = new ViewModelCommand(ExecuteShowStockViewCommand);
            ShowProductsViewCommand = new ViewModelCommand(ExecuteShowProductsViewCommand);

            //Default View
            ExecuteShowHomeViewCommand(null);

        }

        private void ExecuteShowProductsViewCommand(object obj)
        {
            CurrentChildView = new ProductsViewModel();
            Caption = "Productos";
            Icon = IconChar.Tag;
        }

        private void ExecuteShowStockViewCommand(object obj){
            
            IStockRepository stockRepository = new StockRepository(testContext);
            CurrentChildView = new StockViewModel(stockRepository);
            Caption = "Stock";
            Icon = IconChar.ChartSimple;
        }

        private void ExecuteShowHomeViewCommand(object obj)
        {
            CurrentChildView = new HomeViewModel();
            Caption = "Home";
            Icon = IconChar.Home;
        }

    }
}
