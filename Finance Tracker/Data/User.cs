using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_Tracker
{
    class User : IUser
    {
        public string Name { get; }
        public decimal CurrentSpending { get; private set; }
        public decimal Budget { get; private set; }

        public List<Spending> Spendings { get; private set; }

        public void UpdateBudget(decimal budget)
        {
            Budget = budget;
        }

        public void UpdateSpending(decimal spent)
        {
            CurrentSpending += spent;
        }

        public string DisplaySpendings()
        {
            StringBuilder results = new StringBuilder();
            foreach (var spending in Spendings )
            {
                results.Append(spending.GetInfo() + "\n");
            }

            return results.ToString();
        }
    }
}
