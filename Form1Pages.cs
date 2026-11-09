using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дипломочка
{
    public partial class Form1
    {
        //Преключатели страниц
        private void ShowHomePage()
        {
            panelMain.Visible = true;
            panelProducts.Visible = false;
            panelIncome.Visible = false;
            panelExpense.Visible = false;
            panelHistory.Visible = false;

            LoadDashboard();
        }
        private void ShowProductsPage()
        {
            panelProducts.Visible = true;
            panelMain.Visible = false;
            panelIncome.Visible = false;
            panelExpense.Visible = false;
            panelHistory.Visible = false;

            LoadDashboardProducts();
        }
        private void ShowIncomePage()
        {
            panelIncome.Visible = true;
            panelMain.Visible = false;
            panelProducts.Visible = false;
            panelExpense.Visible = false;
            panelHistory.Visible = false;

            LoadIncomeProducts();
        }
        private void ShowExpensePage()
        {
            panelExpense.Visible = true;
            panelMain.Visible = false;
            panelProducts.Visible = false;
            panelIncome.Visible = false;
            panelHistory.Visible = false;

            LoadExpenseProducts();
        }
        private void ShowHistoryPage()
        {
            panelHistory.Visible = true;
            panelMain.Visible = false;
            panelProducts.Visible = false;
            panelIncome.Visible = false;
            panelExpense.Visible = false;

            LoadHistory();
        }
    }
}
