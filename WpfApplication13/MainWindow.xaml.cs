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
using WpfApplication13.Models;

namespace WpfApplication13
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var postit1 = default(Postit);
            var postit2 = default(Postit);

            this.DataContext = new WpfApplication13.Models.Shape[]
            {
                (postit1 = new Postit
                {
                    Top = 10,
                    Left = 10,
                    Width = 100,
                    Height = 100,
                    Text = "Hello",
                }),
                (postit2 = new Postit
                {
                    Top = 110,
                    Left = 130,
                    Width = 100,
                    Height = 100,
                    Text = "world",
                }),
                new Connector
                {
                    Area1 = postit1,
                    Area2 = postit2,
                },
            };
        }
    }
}
