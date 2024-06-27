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

namespace PROG6221_POE_ST10067956.Views.UserControls
{
    /// <summary>
    /// Interaction logic for RecipeViewUC.xaml
    /// </summary>
    public partial class RecipeViewUC : UserControl
    {
        public RecipeViewUC()
        {
            InitializeComponent();
        }

        private void btnRecSearch_Click(object sender, RoutedEventArgs e)
        {
            lstRecipe.Items.Clear();


        }
    }
}
