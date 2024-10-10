using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_Tracker
{
    public partial class MainWindow
    {
        LoadDB loadDB = new LoadDB();

        public void UpdateGreetings()
        {
            string name = loadDB.LoadUser("name");

            greetingsTxt.Content = $"Hello,{name}!";
        }

        public void UpdateBudget()
        {
            string spending = loadDB.LoadUser("current spending");
            spendingStatusTxt.Content = $"Current Spending: £{spending.ToString()}";
        }

        public void UpdateCurrentSpending()
        {
            string budget = loadDB.LoadUser("budget");
            budgetStatusTxt.Content = $"Budget: £{budget}";
        }

        public void UpdateExpenses()
        {
            string results = loadDB.LoadUserData();
            viewResultsTxt.Text = results;
        }
    }
}
