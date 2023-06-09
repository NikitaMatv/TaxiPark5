﻿using System;
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
using TaxiDriwerWpf.Components;

namespace TaxiDriwerWpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfilDriwerPages.xaml
    /// </summary>
    public partial class ProfilDriwerPages : Page
    {
        Emplooy contextemploy;
        public ProfilDriwerPages(Emplooy emplooy)
        {
            InitializeComponent();
           
            contextemploy = emplooy;
            DataContext = contextemploy;
            var List = App.DB.Order.Where(x => x.TaxistId == App.Id).Where(x => x.IsAccept == 3) ;
            if (List.Sum(x => x.Price) == null)
            {
                Money.Text = $"0 руб.";
            }
            else
            Money.Text =$"{ List.Sum(x=>x.Price) } руб."; 

        }



        private void MainClientBt_Click(object sender, RoutedEventArgs e)

        {
            NavigationService.Navigate(new MainOperatorPages());
        }

        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {
            App.LoggedEmployee = null;
            NavigationService.Navigate(new AutorPages());
        }

        private void EditBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditDriwerPages(App.LoggedEmployee));
        }
    }
}
