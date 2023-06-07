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
using TaxiDriwerWpf.Components;

namespace TaxiDriwerWpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для HistoriPages.xaml
    /// </summary>
    public partial class HistoriPages : Page
    {
        public HistoriPages()
        {
            InitializeComponent();
            
            LvAccept.ItemsSource = App.DB.Order.Where(x => x.TaxistId == App.LoggedEmployee.Id).Where(x => x.IsAccept == 3).ToList();
            if(LvAccept.Items.Count == 0)
            {
                SpTaxi.Visibility = Visibility.Visible;
            }
        }

       
    }
}
