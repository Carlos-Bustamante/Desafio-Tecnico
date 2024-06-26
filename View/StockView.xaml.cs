﻿using Desafio_Tecnico.Models;
using Desafio_Tecnico.Repositories;
using Desafio_Tecnico.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Desafio_Tecnico.View
{
    /// <summary>
    /// Lógica de interacción para StockView.xaml
    /// </summary>
    public partial class StockView : UserControl
    {
        public StockView()
        {
            InitializeComponent();
            var context = new TestContext();
            var repository = new StockRepository(context);
            this.DataContext = new StockViewModel(repository);
        }
    }
}
