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
    /// Interaction logic for AddSpendingWindow.xaml
    /// </summary>
    public partial class AddSpendingWindow : Window
    {
        public AddSpendingWindow()
        {
            InitializeComponent();
        }

        private void addSpendingBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadDB loadDB = new LoadDB();

            string item = transactionItemTxt.Text.ToString();
            double amount = Double.Parse(amountTxt.Text);
            DateTime transactionDate = new DateTime(int.Parse(yearTxt.Text),int.Parse(monthTxt.Text),int.Parse(dayTxt.Text));

            loadDB.AddUserSpending(item, amount, transactionDate);

            this.DialogResult = true;
            MessageBox.Show("Transaction Added");
            this.Close();
        }
    }
}
