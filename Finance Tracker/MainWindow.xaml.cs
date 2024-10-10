using Finance_Tracker.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Diagnostics;
using System.Windows.Navigation;

namespace Finance_Tracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<string> CurrencyList = new ObservableCollection<string>
        {
        "USD", "GBP", "EUR", "JPY", "AUD"
        };

        public MainWindow()
        {
            InitializeComponent();
            fromCurrenciesMenu.ItemsSource = CurrencyList;
            toCurrenciesMenu.ItemsSource = CurrencyList;

            UpdateGreetings();
            UpdateBudget();
            UpdateCurrentSpending();
        }

        private async void convertBtn_Click(object sender, RoutedEventArgs e)
        {
            string fromCurrency = fromCurrenciesMenu.SelectedItem as string;
            string toCurrency = toCurrenciesMenu.SelectedItem as string;
            
            decimal amount = Decimal.Parse(fromCurrencyTxt.Text);

            try
            {
                decimal convertedAmount = await Currency.ConvertCurrency(fromCurrency, toCurrency, amount);
                toCurrencyTxt.Text = convertedAmount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void viewBtn_Click(object sender, RoutedEventArgs e)
        {

            UpdateExpenses();
        }

        private void budgetBtn_Click(object sender, RoutedEventArgs e)
        {
            BudgetWindow budgetWindow = new BudgetWindow();
            bool? dialogResult = budgetWindow.ShowDialog();

            if(dialogResult == true)
            {
                UpdateBudget();
            }
            
        }

        private void addExpenseBtn_Click(object sender, RoutedEventArgs e)
        {
            AddSpendingWindow addSpending = new AddSpendingWindow();
            bool? dialogResult = addSpending.ShowDialog();

            if(dialogResult == true)
            {
                UpdateCurrentSpending();
                UpdateExpenses();
            }
        }

        
    }
}
