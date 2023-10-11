using entity_framework_codefirst.Model.Database.Entity;
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

namespace entity_framework_codefirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model1 db = new Model1();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ChuongHeo chuongHeo = new ChuongHeo();
            //chuongHeo.MaChuong = "ChuongHeo01";
            //chuongHeo.SoLuongHeo = 0;
            //chuongHeo.SucChuaToiDa = 10;
            //chuongHeo.TinhTrang = "Tot";
            //db.ChuongHeos.Add(chuongHeo); 
            //db.SaveChanges();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int soChuong = db.ChuongHeos.ToList().Count;
            MessageBox.Show(soChuong.ToString());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
