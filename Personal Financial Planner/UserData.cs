﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba_proekt
{
    public class UserData
    {
        public List<ExpenseItem> FoodExpenses { get; set; }
        public List<ExpenseItem> ClothesExpenses { get; set; }
        public List<ExpenseItem> EntertainmentExpenses { get; set; }
        public List<ExpenseItem> UtilityExpenses { get; set; }
        public decimal MonthlyIncome { get; set; }
        public decimal AdditionalIncome { get; set; }
        public decimal MonthlySavings { get; set; }
        public decimal TotalSavings { get; set; }
        public decimal SpendableAmount { get; set; }
        public decimal TransportCost { get; set; }

        public UserData()
        {
            FoodExpenses = new List<ExpenseItem>();
            ClothesExpenses = new List<ExpenseItem>();
            EntertainmentExpenses = new List<ExpenseItem>();
            UtilityExpenses = new List<ExpenseItem>();
        }
    }
}
