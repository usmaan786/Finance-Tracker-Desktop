using Finance_Tracker.Data;
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
using System.Windows.Shapes;

namespace Finance_Tracker
{
    /// <summary>
    /// Interaction logic for BudgetWindow.xaml
    /// </summary>
    public partial class BudgetWindow : Window
    {
        public BudgetWindow()
        {
            InitializeComponent();
        }

        private void setBudgetBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadDB loadDB = new LoadDB();

            loadDB.UpdateUserBudget(Double.Parse(budgetText.Text));
            MessageBox.Show("Budget Updated");

            this.DialogResult = true;
            this.Close();

        }
    }
}
