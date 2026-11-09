using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Дипломочка.Models;

namespace Дипломочка
{
    public partial class Form1
    {
        //Загрузка данных про операции
        private void LoadDashboard()
        {
            Database database = new Database();

            //Обновление статистики
            lblProductsCount.Text =
                database.GetProductCount().ToString();

            lblCategoriesCount.Text =
                database.GetCategoryCount().ToString();

            lblLowStockCount.Text =
                database.GetLowStockCount().ToString();

            //Настройка таблицы
            dgvOperations.AutoGenerateColumns = true;
            dgvOperations.ReadOnly = true;
            dgvOperations.AllowUserToAddRows = false;
            dgvOperations.MultiSelect = false;

            dgvOperations.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvOperations.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            //Загрузка последних операций
            dgvOperations.DataSource = null;
            dgvOperations.DataSource =
                database.GetRecentOperations();

            //Имена столбцов
            if (dgvOperations.Columns.Contains("ProductName"))
                dgvOperations.Columns["ProductName"].HeaderText = "Product";

            if (dgvOperations.Columns.Contains("OperationType"))
                dgvOperations.Columns["OperationType"].HeaderText = "Operation";

            if (dgvOperations.Columns.Contains("OperationDate"))
                dgvOperations.Columns["OperationDate"].HeaderText = "Date";

            if (dgvOperations.Columns.Contains("ProductId"))
                dgvOperations.Columns["ProductId"].Visible = false;
        }
        private void LoadDashboardProducts()
        {
            Database database = new Database();

            lblPriceCount2.Text = database.GetTotalStockValue().ToString("N2");
            lblCategoriesCount2.Text = database.GetProductCount().ToString();
            lblProductsCount2.Text = database.GetCategoryCount().ToString();
        }
        private void LoadIncomeProducts()
        {
            Database database = new Database();

            List<Product> products = database.GetProducts();

            cmbIncomeProduct.DataSource = null;
            cmbIncomeProduct.DisplayMember = nameof(Product.Name);
            cmbIncomeProduct.ValueMember = nameof(Product.Id);
            cmbIncomeProduct.DataSource = products;

            cmbIncomeProduct.Enabled = products.Count > 0;
            btnRegisterIncome.Enabled = products.Count > 0;
        }
        private void LoadExpenseProducts()
        {
            Database database = new Database();

            List<Product> products = database.GetProducts();

            cmbExpenseProduct.DataSource = null;
            cmbExpenseProduct.DisplayMember = nameof(Product.Name);
            cmbExpenseProduct.ValueMember = nameof(Product.Id);
            cmbExpenseProduct.DataSource = products;

            cmbExpenseProduct.Enabled = products.Count > 0;
            btnRegisterExpense.Enabled = products.Count > 0;
        }
        //Список продуктов для таблицы
        private void LoadProducts(string searchText = "")
        {
            Database database = new Database();

            //НАстройка таблицы
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProducts.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.DataSource = null;
            List<Product> products = database.SearchProducts(searchText);
            //Варианты фильтраций
            switch (cmbSort.SelectedIndex)
            {
                case 1:
                    products = products
                        .OrderBy(p => p.Name)
                        .ToList();
                    break;

                case 2:
                    products = products
                        .OrderBy(p => p.Price)
                        .ToList();
                    break;

                case 3:
                    products = products
                        .OrderByDescending(p => p.Price)
                        .ToList();
                    break;

                case 4:
                    products = products
                        .OrderBy(p => p.Quantity)
                        .ToList();
                    break;

                case 5:
                    products = products
                        .OrderByDescending(p => p.Quantity)
                        .ToList();
                    break;
            }
            //Обновление данных
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
        }

        private void LoadHistory()
        {
            Database database = new Database();

            dgvHistory.AutoGenerateColumns = true;
            dgvHistory.ReadOnly = true;
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.MultiSelect = false;

            dgvHistory.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvHistory.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvHistory.DataSource = null;
            dgvHistory.DataSource = database.GetOperations();

            if (dgvHistory.Columns.Contains("Id"))
                dgvHistory.Columns["Id"].HeaderText = "ID";

            if (dgvHistory.Columns.Contains("ProductId"))
                dgvHistory.Columns["ProductId"].HeaderText = "Product ID";

            if (dgvHistory.Columns.Contains("ProductName"))
                dgvHistory.Columns["ProductName"].HeaderText = "Product";

            if (dgvHistory.Columns.Contains("OperationType"))
                dgvHistory.Columns["OperationType"].HeaderText = "Operation";

            if (dgvHistory.Columns.Contains("Quantity"))
                dgvHistory.Columns["Quantity"].HeaderText = "Quantity";

            if (dgvHistory.Columns.Contains("OperationDate"))
                dgvHistory.Columns["OperationDate"].HeaderText = "Date";
        }
    }
}
