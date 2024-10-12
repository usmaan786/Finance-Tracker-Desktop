using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Finance_Tracker
{
    public partial class MainWindowView
    {
        LoadDB loadDB = new LoadDB();

        public void UpdateGreetings()
        {
            string name = loadDB.LoadUser("name");

            greetingsTxt.Text = $"Hello,{name}!";
        }

        public void UpdateCurrentSpending()
        {
            string spending = loadDB.LoadUser("current spending");
            spendingStatusTxt.Text = $"Current Spending: £{spending.ToString()}";
        }

        public void UpdateBudget()
        {
            string budget = loadDB.LoadUser("budget");
            budgetStatusTxt.Text = $"Budget: £{budget}";
        }

        public void UpdateExpenses()
        {
            var spendings = loadDB.LoadUserData();
            expensesListView.ItemsSource = spendings;
        }

    }
}
