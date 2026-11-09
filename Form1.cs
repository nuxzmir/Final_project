using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Дипломочка;
using Microsoft.Data.Sqlite;
using Дипломочка.Models;
using System.Linq;

namespace Дипломочка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            ApplyStyles();

            //Добавление БД в проект
            Database database = new Database();
            database.InitializeDatabase();

            //Установка фильтра в исходное положение
            cmbSort.SelectedIndex = 0;

            LoadProducts();

            LoadDashboard();

            LoadDashboardProducts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblProductsCount_Click(object sender, EventArgs e)
        {

        }

        private void lblProductsText_Click(object sender, EventArgs e)
        {

        }

        private void panelProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLowStockText_Click(object sender, EventArgs e)
        {

        }

        private void dgvOperations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblProductsTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            ShowHomePage();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ShowProductsPage();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //Уборка ненужных пробелов
            string name = txtProductName.Text.Trim();
            string category = txtCategory.Text.Trim();
            //Проверки ввода
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Enter correct product name!");
                return;
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Enter the category of product!");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity)
                || quantity <= 0)
            {
                MessageBox.Show("Enter correct quantity!");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price)
                || price <= 0)
            {
                MessageBox.Show("Enter correct price!");
                return;
            }
            //Присваивание данных
            Product product = new Product
            {
                Name = name,
                Category = category,
                Quantity = quantity,
                Price = price
            };
            //Добавление продукта в БД
            try
            {
                Database database = new Database();
                database.AddProduct(product);
                LoadProducts();

                MessageBox.Show("Product added succesfully!");
                LoadDashboardProducts();

                txtProductName.Clear();
                txtCategory.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();

                txtProductName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не удалось добавить товар.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelProducts_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            //Выбор продукта из таблицы
            if (dgvProducts.CurrentRow?.DataBoundItem is not Product product)
                return;

            txtProductName.Text = product.Name;
            txtCategory.Text = product.Category;
            txtQuantity.Text = product.Quantity.ToString();
            txtPrice.Text = product.Price.ToString();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            //Проверка выделенного товара
            if (dgvProducts.CurrentRow?.DataBoundItem is not Product product)
            {
                MessageBox.Show("Select a product first.");
                return;
            }

            //Подтверждение удаления
            DialogResult result = MessageBox.Show(
                $"Delete '{product.Name}'?",
                "Confirm deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                //Вызов удаления и очищение
                Database database = new Database();
                database.DeleteProduct(product.Id);

                LoadProducts(txtSearch.Text);

                txtProductName.Clear();
                txtCategory.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();

                MessageBox.Show("Product deleted successfully.");
                LoadDashboardProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            //Проверка выделенного товара
            if (dgvProducts.CurrentRow?.DataBoundItem is not Product selectedProduct)
            {
                MessageBox.Show("Select a product first.");
                return;
            }

            //Обрезка пробелов
            string name = txtProductName.Text.Trim();
            string category = txtCategory.Text.Trim();

            //Проверки правильного ввода
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Enter the product name and category.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) ||
                quantity <= 0)
            {
                MessageBox.Show("Enter a valid quantity.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) ||
                price <= 0)
            {
                MessageBox.Show("Enter a valid price.");
                return;
            }

            //Присваивание новых данных
            Product updatedProduct = new Product
            {
                Id = selectedProduct.Id,
                Name = name,
                Category = category,
                Quantity = quantity,
                Price = price
            };

            try
            {
                Database database = new Database();
                database.UpdateProduct(updatedProduct);

                LoadProducts(txtSearch.Text);

                MessageBox.Show("Product updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblProductsDGV_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text.Trim());
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text.Trim());
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            ShowIncomePage();
        }

        private void lblIncomeQuantity_Click(object sender, EventArgs e)
        {

        }

        private void btnRegisterIncome_Click(object sender, EventArgs e)
        {
            //Проверка выделения
            if (cmbIncomeProduct.SelectedItem is not Product product)
            {
                MessageBox.Show("Select a product first.");
                return;
            }

            //Перевод в интеджер
            int quantity = Decimal.ToInt32(numIncomeQuantity.Value);

            //Регистрация дохода
            try
            {
                Database database = new Database();

                database.RegisterOperation(
                    product.Id,
                    "Income",
                    quantity
                );

                LoadProducts(txtSearch.Text.Trim());
                LoadIncomeProducts();

                MessageBox.Show("Income registered successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not register income: " + ex.Message
                );
            }
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            ShowExpensePage();
        }

        private void btnRegisterExpense_Click(object sender, EventArgs e)
        {
            //Проверка выделения
            if (cmbExpenseProduct.SelectedItem is not Product product)
            {
                MessageBox.Show("Select a product first.");
                return;
            }

            //Перевод в интеджер
            int quantity = Decimal.ToInt32(numExpenseQuantity.Value);

            //Регистрация затрат
            try
            {
                Database database = new Database();

                database.RegisterOperation(
                    product.Id,
                    "Expense",
                    quantity
                );

                LoadProducts(txtSearch.Text.Trim());
                LoadExpenseProducts();

                MessageBox.Show("Expense registered successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not register expense: " + ex.Message
                );
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ShowHistoryPage();
        }

        private void lblExpenseTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblExpenseQuantity_Click(object sender, EventArgs e)
        {

        }

        private void lblPriceCount2_Click(object sender, EventArgs e)
        {

        }
    }
}
