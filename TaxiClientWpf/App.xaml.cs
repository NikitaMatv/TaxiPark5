using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TaxiClientWpf.Components;
namespace TaxiClientWpf
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static TaxiDB2Entities DB = new TaxiDB2Entities();
        public static Emplooy LoggedEmployee;
        public static bool IsAutorizate = false;
    }
}
