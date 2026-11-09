namespace Дипломочка
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelMenu = new Panel();
            btnHistory = new Button();
            btnExpense = new Button();
            btnIncome = new Button();
            btnCategories = new Button();
            btnProducts = new Button();
            btnHome = new Button();
            lblLogo = new Label();
            panelMain = new Panel();
            lblOperations = new Label();
            dgvOperations = new DataGridView();
            frameCategories = new Panel();
            lblCategoriesText = new Label();
            lblCategoriesCount = new Label();
            frameStock = new Panel();
            lblLowStockText = new Label();
            lblLowStockCount = new Label();
            frameProducts = new Panel();
            lblProductsText = new Label();
            lblProductsCount = new Label();
            lblMain = new Label();
            panelProducts = new Panel();
            lblProducts = new Label();
            cmbSort = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            frameProductsInfo = new Panel();
            lblCategoriesCount2 = new Label();
            lblPriceCount2 = new Label();
            lblCategoriesText2 = new Label();
            lblPriceText2 = new Label();
            lblProductsText2 = new Label();
            lblProductsCount2 = new Label();
            btnDeleteProduct = new Button();
            btnEditProduct = new Button();
            lblProductsDGV = new Label();
            dgvProducts = new DataGridView();
            txtPrice = new TextBox();
            lblProductsTitle = new Label();
            txtQuantity = new TextBox();
            lblProductName = new Label();
            txtCategory = new TextBox();
            lblCategory = new Label();
            txtProductName = new TextBox();
            lblQuantity = new Label();
            btnAddProduct = new Button();
            lblPrice = new Label();
            panelIncome = new Panel();
            frameRegIncome = new Panel();
            lblIncomeTitle = new Label();
            btnRegisterIncome = new Button();
            numIncomeQuantity = new NumericUpDown();
            lblIncomeProduct = new Label();
            cmbIncomeProduct = new ComboBox();
            lblIncomeQuantity = new Label();
            lblIncome = new Label();
            panelExpense = new Panel();
            lblExpense = new Label();
            frameRegExpense = new Panel();
            lblExpenseTitle = new Label();
            btnRegisterExpense = new Button();
            numExpenseQuantity = new NumericUpDown();
            lblExpenseProduct = new Label();
            cmbExpenseProduct = new ComboBox();
            lblExpenseQuantity = new Label();
            panelHistory = new Panel();
            dgvHistory = new DataGridView();
            lblHistory = new Label();
            panelMenu.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOperations).BeginInit();
            frameCategories.SuspendLayout();
            frameStock.SuspendLayout();
            frameProducts.SuspendLayout();
            panelProducts.SuspendLayout();
            frameProductsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panelIncome.SuspendLayout();
            frameRegIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIncomeQuantity).BeginInit();
            panelExpense.SuspendLayout();
            frameRegExpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numExpenseQuantity).BeginInit();
            panelHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.MidnightBlue;
            panelMenu.Controls.Add(btnHistory);
            panelMenu.Controls.Add(btnExpense);
            panelMenu.Controls.Add(btnIncome);
            panelMenu.Controls.Add(btnCategories);
            panelMenu.Controls.Add(btnProducts);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Location = new Point(13, 288);
            panelMenu.Margin = new Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(257, 367);
            panelMenu.TabIndex = 0;
            panelMenu.Tag = "panelMenu";
            panelMenu.Paint += panelMenu_Paint;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.MidnightBlue;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnHistory.ForeColor = Color.White;
            btnHistory.Location = new Point(14, 305);
            btnHistory.Margin = new Padding(4, 3, 4, 3);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(233, 52);
            btnHistory.TabIndex = 7;
            btnHistory.Text = "📜 History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnExpense
            // 
            btnExpense.BackColor = Color.MidnightBlue;
            btnExpense.FlatAppearance.BorderSize = 0;
            btnExpense.FlatStyle = FlatStyle.Flat;
            btnExpense.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExpense.ForeColor = Color.White;
            btnExpense.Location = new Point(14, 246);
            btnExpense.Margin = new Padding(4, 3, 4, 3);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(233, 52);
            btnExpense.TabIndex = 6;
            btnExpense.Text = "📤 Expense";
            btnExpense.UseVisualStyleBackColor = false;
            btnExpense.Click += btnExpense_Click;
            // 
            // btnIncome
            // 
            btnIncome.BackColor = Color.MidnightBlue;
            btnIncome.FlatAppearance.BorderSize = 0;
            btnIncome.FlatStyle = FlatStyle.Flat;
            btnIncome.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnIncome.ForeColor = Color.White;
            btnIncome.Location = new Point(14, 187);
            btnIncome.Margin = new Padding(4, 3, 4, 3);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(233, 52);
            btnIncome.TabIndex = 5;
            btnIncome.Text = "📥 Income";
            btnIncome.UseVisualStyleBackColor = false;
            btnIncome.Click += btnIncome_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.MidnightBlue;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(12, 129);
            btnCategories.Margin = new Padding(4, 3, 4, 3);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(233, 52);
            btnCategories.TabIndex = 3;
            btnCategories.Text = "🗂 Categories (X)";
            btnCategories.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.MidnightBlue;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(12, 70);
            btnProducts.Margin = new Padding(4, 3, 4, 3);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(233, 52);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "📦 Products";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.MidnightBlue;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(12, 12);
            btnHome.Margin = new Padding(4, 3, 4, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(233, 52);
            btnHome.TabIndex = 1;
            btnHome.Text = "🏠 Main";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click_1;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Avignon Pro", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(23, 225);
            lblLogo.Margin = new Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(247, 43);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Warehouse📦";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            lblLogo.Click += lblLogo_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.AliceBlue;
            panelMain.Controls.Add(lblOperations);
            panelMain.Controls.Add(dgvOperations);
            panelMain.Controls.Add(frameCategories);
            panelMain.Controls.Add(frameStock);
            panelMain.Controls.Add(frameProducts);
            panelMain.Controls.Add(lblMain);
            panelMain.Location = new Point(281, 14);
            panelMain.Margin = new Padding(4, 3, 4, 3);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1610, 1015);
            panelMain.TabIndex = 2;
            panelMain.Paint += panelMain_Paint;
            // 
            // lblOperations
            // 
            lblOperations.AutoSize = true;
            lblOperations.Font = new Font("Avignon Pro", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOperations.Location = new Point(20, 366);
            lblOperations.Margin = new Padding(4, 0, 4, 0);
            lblOperations.Name = "lblOperations";
            lblOperations.Size = new Size(429, 55);
            lblOperations.TabIndex = 4;
            lblOperations.Text = "Recent Operations:";
            // 
            // dgvOperations
            // 
            dgvOperations.AllowUserToOrderColumns = true;
            dgvOperations.BackgroundColor = SystemColors.ControlLight;
            dgvOperations.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOperations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOperations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOperations.EnableHeadersVisualStyles = false;
            dgvOperations.GridColor = Color.SkyBlue;
            dgvOperations.Location = new Point(20, 436);
            dgvOperations.Margin = new Padding(4, 3, 4, 3);
            dgvOperations.Name = "dgvOperations";
            dgvOperations.ReadOnly = true;
            dgvOperations.Size = new Size(1566, 556);
            dgvOperations.TabIndex = 3;
            dgvOperations.CellContentClick += dgvOperations_CellContentClick;
            // 
            // frameCategories
            // 
            frameCategories.BackColor = SystemColors.ControlLight;
            frameCategories.Controls.Add(lblCategoriesText);
            frameCategories.Controls.Add(lblCategoriesCount);
            frameCategories.Location = new Point(405, 67);
            frameCategories.Margin = new Padding(4, 3, 4, 3);
            frameCategories.Name = "frameCategories";
            frameCategories.Size = new Size(351, 245);
            frameCategories.TabIndex = 2;
            frameCategories.Paint += panel2_Paint;
            // 
            // lblCategoriesText
            // 
            lblCategoriesText.AutoSize = true;
            lblCategoriesText.Font = new Font("Avignon Pro", 27.75F);
            lblCategoriesText.Location = new Point(70, 52);
            lblCategoriesText.Margin = new Padding(4, 0, 4, 0);
            lblCategoriesText.Name = "lblCategoriesText";
            lblCategoriesText.Size = new Size(204, 43);
            lblCategoriesText.TabIndex = 3;
            lblCategoriesText.Text = "Categories:";
            // 
            // lblCategoriesCount
            // 
            lblCategoriesCount.AutoSize = true;
            lblCategoriesCount.Font = new Font("Avignon Pro", 27.75F);
            lblCategoriesCount.Location = new Point(153, 140);
            lblCategoriesCount.Margin = new Padding(4, 0, 4, 0);
            lblCategoriesCount.Name = "lblCategoriesCount";
            lblCategoriesCount.Size = new Size(37, 43);
            lblCategoriesCount.TabIndex = 2;
            lblCategoriesCount.Text = "0";
            // 
            // frameStock
            // 
            frameStock.BackColor = SystemColors.ControlLight;
            frameStock.Controls.Add(lblLowStockText);
            frameStock.Controls.Add(lblLowStockCount);
            frameStock.Location = new Point(784, 67);
            frameStock.Margin = new Padding(4, 3, 4, 3);
            frameStock.Name = "frameStock";
            frameStock.Size = new Size(351, 245);
            frameStock.TabIndex = 2;
            // 
            // lblLowStockText
            // 
            lblLowStockText.AutoSize = true;
            lblLowStockText.Font = new Font("Avignon Pro", 27.75F);
            lblLowStockText.Location = new Point(51, 52);
            lblLowStockText.Margin = new Padding(4, 0, 4, 0);
            lblLowStockText.Name = "lblLowStockText";
            lblLowStockText.Size = new Size(240, 43);
            lblLowStockText.TabIndex = 5;
            lblLowStockText.Text = "Low On Stock:";
            lblLowStockText.Click += lblLowStockText_Click;
            // 
            // lblLowStockCount
            // 
            lblLowStockCount.AutoSize = true;
            lblLowStockCount.Font = new Font("Avignon Pro", 27.75F);
            lblLowStockCount.Location = new Point(151, 144);
            lblLowStockCount.Margin = new Padding(4, 0, 4, 0);
            lblLowStockCount.Name = "lblLowStockCount";
            lblLowStockCount.Size = new Size(37, 43);
            lblLowStockCount.TabIndex = 4;
            lblLowStockCount.Text = "0";
            // 
            // frameProducts
            // 
            frameProducts.BackColor = SystemColors.ControlLight;
            frameProducts.Controls.Add(lblProductsText);
            frameProducts.Controls.Add(lblProductsCount);
            frameProducts.Location = new Point(27, 67);
            frameProducts.Margin = new Padding(4, 3, 4, 3);
            frameProducts.Name = "frameProducts";
            frameProducts.Size = new Size(351, 245);
            frameProducts.TabIndex = 1;
            frameProducts.Paint += panelProducts_Paint;
            // 
            // lblProductsText
            // 
            lblProductsText.AutoSize = true;
            lblProductsText.Font = new Font("Avignon Pro", 27.75F);
            lblProductsText.Location = new Point(73, 52);
            lblProductsText.Margin = new Padding(4, 0, 4, 0);
            lblProductsText.Name = "lblProductsText";
            lblProductsText.Size = new Size(192, 43);
            lblProductsText.TabIndex = 1;
            lblProductsText.Text = "Total Items:";
            lblProductsText.Click += lblProductsText_Click;
            // 
            // lblProductsCount
            // 
            lblProductsCount.AutoSize = true;
            lblProductsCount.Font = new Font("Avignon Pro", 27.75F);
            lblProductsCount.Location = new Point(151, 144);
            lblProductsCount.Margin = new Padding(4, 0, 4, 0);
            lblProductsCount.Name = "lblProductsCount";
            lblProductsCount.Size = new Size(37, 43);
            lblProductsCount.TabIndex = 0;
            lblProductsCount.Text = "0";
            lblProductsCount.Click += lblProductsCount_Click;
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Font = new Font("Avignon Pro", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMain.Location = new Point(20, 14);
            lblMain.Margin = new Padding(4, 0, 4, 0);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(80, 34);
            lblMain.TabIndex = 0;
            lblMain.Text = "Main";
            // 
            // panelProducts
            // 
            panelProducts.BackColor = SystemColors.Control;
            panelProducts.Controls.Add(lblProducts);
            panelProducts.Controls.Add(cmbSort);
            panelProducts.Controls.Add(btnSearch);
            panelProducts.Controls.Add(txtSearch);
            panelProducts.Controls.Add(frameProductsInfo);
            panelProducts.Controls.Add(btnDeleteProduct);
            panelProducts.Controls.Add(btnEditProduct);
            panelProducts.Controls.Add(lblProductsDGV);
            panelProducts.Controls.Add(dgvProducts);
            panelProducts.Controls.Add(txtPrice);
            panelProducts.Controls.Add(lblProductsTitle);
            panelProducts.Controls.Add(txtQuantity);
            panelProducts.Controls.Add(lblProductName);
            panelProducts.Controls.Add(txtCategory);
            panelProducts.Controls.Add(lblCategory);
            panelProducts.Controls.Add(txtProductName);
            panelProducts.Controls.Add(lblQuantity);
            panelProducts.Controls.Add(btnAddProduct);
            panelProducts.Controls.Add(lblPrice);
            panelProducts.Location = new Point(281, 14);
            panelProducts.Name = "panelProducts";
            panelProducts.Size = new Size(1611, 1015);
            panelProducts.TabIndex = 3;
            panelProducts.Visible = false;
            panelProducts.Paint += panelProducts_Paint_1;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Avignon Pro", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProducts.Location = new Point(20, 14);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(126, 34);
            lblProducts.TabIndex = 22;
            lblProducts.Text = "Products";
            // 
            // cmbSort
            // 
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.Font = new Font("Avignon Pro", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] { "Newest first", "Name (A-Z)", "Price (low to high)", "Price (high to low)", "Quantity (low to high)", "Quantity (high to low)" });
            cmbSort.Location = new Point(653, 91);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(349, 51);
            cmbSort.TabIndex = 21;
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Avignon Pro", 36F);
            btnSearch.Location = new Point(1350, 76);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(189, 70);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Avignon Pro", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(1008, 81);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(336, 63);
            txtSearch.TabIndex = 19;
            // 
            // frameProductsInfo
            // 
            frameProductsInfo.BackColor = SystemColors.ControlLight;
            frameProductsInfo.Controls.Add(lblCategoriesCount2);
            frameProductsInfo.Controls.Add(lblPriceCount2);
            frameProductsInfo.Controls.Add(lblCategoriesText2);
            frameProductsInfo.Controls.Add(lblPriceText2);
            frameProductsInfo.Controls.Add(lblProductsText2);
            frameProductsInfo.Controls.Add(lblProductsCount2);
            frameProductsInfo.Location = new Point(41, 148);
            frameProductsInfo.Margin = new Padding(4, 3, 4, 3);
            frameProductsInfo.Name = "frameProductsInfo";
            frameProductsInfo.Size = new Size(563, 190);
            frameProductsInfo.TabIndex = 2;
            // 
            // lblCategoriesCount2
            // 
            lblCategoriesCount2.AutoSize = true;
            lblCategoriesCount2.Font = new Font("Avignon Pro", 36F);
            lblCategoriesCount2.Location = new Point(340, 70);
            lblCategoriesCount2.Margin = new Padding(4, 0, 4, 0);
            lblCategoriesCount2.Name = "lblCategoriesCount2";
            lblCategoriesCount2.Size = new Size(48, 55);
            lblCategoriesCount2.TabIndex = 24;
            lblCategoriesCount2.Text = "0";
            // 
            // lblPriceCount2
            // 
            lblPriceCount2.AutoSize = true;
            lblPriceCount2.Font = new Font("Avignon Pro", 36F);
            lblPriceCount2.Location = new Point(261, 127);
            lblPriceCount2.Margin = new Padding(4, 0, 4, 0);
            lblPriceCount2.Name = "lblPriceCount2";
            lblPriceCount2.Size = new Size(48, 55);
            lblPriceCount2.TabIndex = 5;
            lblPriceCount2.Text = "0";
            lblPriceCount2.Click += lblPriceCount2_Click;
            // 
            // lblCategoriesText2
            // 
            lblCategoriesText2.AutoSize = true;
            lblCategoriesText2.Font = new Font("Avignon Pro", 36F);
            lblCategoriesText2.Location = new Point(15, 15);
            lblCategoriesText2.Margin = new Padding(4, 0, 4, 0);
            lblCategoriesText2.Name = "lblCategoriesText2";
            lblCategoriesText2.Size = new Size(373, 55);
            lblCategoriesText2.TabIndex = 4;
            lblCategoriesText2.Text = "Total Categories:";
            // 
            // lblPriceText2
            // 
            lblPriceText2.AutoSize = true;
            lblPriceText2.Font = new Font("Avignon Pro", 36F);
            lblPriceText2.Location = new Point(15, 125);
            lblPriceText2.Margin = new Padding(4, 0, 4, 0);
            lblPriceText2.Name = "lblPriceText2";
            lblPriceText2.Size = new Size(247, 55);
            lblPriceText2.TabIndex = 2;
            lblPriceText2.Text = "Total Price:";
            // 
            // lblProductsText2
            // 
            lblProductsText2.AutoSize = true;
            lblProductsText2.Font = new Font("Avignon Pro", 36F);
            lblProductsText2.Location = new Point(15, 70);
            lblProductsText2.Margin = new Padding(4, 0, 4, 0);
            lblProductsText2.Name = "lblProductsText2";
            lblProductsText2.Size = new Size(325, 55);
            lblProductsText2.TabIndex = 1;
            lblProductsText2.Text = "Total Products:";
            // 
            // lblProductsCount2
            // 
            lblProductsCount2.AutoSize = true;
            lblProductsCount2.Font = new Font("Avignon Pro", 36F);
            lblProductsCount2.Location = new Point(386, 15);
            lblProductsCount2.Margin = new Padding(4, 0, 4, 0);
            lblProductsCount2.Name = "lblProductsCount2";
            lblProductsCount2.Size = new Size(48, 55);
            lblProductsCount2.TabIndex = 0;
            lblProductsCount2.Text = "0";
            lblProductsCount2.Click += label3_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Font = new Font("Avignon Pro", 36F);
            btnDeleteProduct.Location = new Point(1140, 898);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(375, 94);
            btnDeleteProduct.TabIndex = 18;
            btnDeleteProduct.Text = "Delete Selected";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Font = new Font("Avignon Pro", 36F);
            btnEditProduct.Location = new Point(678, 898);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(375, 94);
            btnEditProduct.TabIndex = 17;
            btnEditProduct.Text = "Edit Selected";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // lblProductsDGV
            // 
            lblProductsDGV.AutoSize = true;
            lblProductsDGV.Font = new Font("Avignon Pro", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductsDGV.Location = new Point(653, 33);
            lblProductsDGV.Name = "lblProductsDGV";
            lblProductsDGV.Size = new Size(290, 55);
            lblProductsDGV.TabIndex = 15;
            lblProductsDGV.Text = "Products List:";
            lblProductsDGV.Click += lblProductsDGV_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToOrderColumns = true;
            dgvProducts.BackgroundColor = SystemColors.ControlLight;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(652, 165);
            dgvProducts.Margin = new Padding(4, 3, 4, 3);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.Size = new Size(887, 704);
            dgvProducts.TabIndex = 5;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Avignon Pro", 29.9999962F);
            txtPrice.Location = new Point(320, 729);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(284, 54);
            txtPrice.TabIndex = 14;
            // 
            // lblProductsTitle
            // 
            lblProductsTitle.AutoSize = true;
            lblProductsTitle.Font = new Font("Avignon Pro", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductsTitle.Location = new Point(151, 378);
            lblProductsTitle.Name = "lblProductsTitle";
            lblProductsTitle.Size = new Size(357, 55);
            lblProductsTitle.TabIndex = 5;
            lblProductsTitle.Text = "Products Edition";
            lblProductsTitle.Click += lblProductsTitle_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Avignon Pro", 29.9999962F);
            txtQuantity.Location = new Point(320, 650);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(284, 54);
            txtQuantity.TabIndex = 13;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Avignon Pro", 29.9999962F);
            lblProductName.Location = new Point(35, 501);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(277, 46);
            lblProductName.TabIndex = 6;
            lblProductName.Text = "Product name:";
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Avignon Pro", 29.9999962F);
            txtCategory.Location = new Point(320, 575);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(284, 54);
            txtCategory.TabIndex = 12;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Avignon Pro", 29.9999962F);
            lblCategory.Location = new Point(120, 575);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(192, 46);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category:";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Avignon Pro", 29.9999962F);
            txtProductName.Location = new Point(320, 501);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(284, 54);
            txtProductName.TabIndex = 11;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Avignon Pro", 29.9999962F);
            lblQuantity.Location = new Point(133, 660);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(179, 46);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Quantity:";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = SystemColors.ControlLightLight;
            btnAddProduct.Font = new Font("Avignon Pro", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProduct.Location = new Point(202, 814);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(273, 82);
            btnAddProduct.TabIndex = 10;
            btnAddProduct.Text = "Add As A New Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Avignon Pro", 29.9999962F);
            lblPrice.Location = new Point(200, 730);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(114, 46);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price:";
            // 
            // panelIncome
            // 
            panelIncome.BackColor = SystemColors.Control;
            panelIncome.Controls.Add(frameRegIncome);
            panelIncome.Controls.Add(lblIncome);
            panelIncome.Location = new Point(281, 14);
            panelIncome.Name = "panelIncome";
            panelIncome.Size = new Size(1611, 1015);
            panelIncome.TabIndex = 4;
            panelIncome.Visible = false;
            // 
            // frameRegIncome
            // 
            frameRegIncome.BackColor = SystemColors.ControlLight;
            frameRegIncome.Controls.Add(lblIncomeTitle);
            frameRegIncome.Controls.Add(btnRegisterIncome);
            frameRegIncome.Controls.Add(numIncomeQuantity);
            frameRegIncome.Controls.Add(lblIncomeProduct);
            frameRegIncome.Controls.Add(cmbIncomeProduct);
            frameRegIncome.Controls.Add(lblIncomeQuantity);
            frameRegIncome.Location = new Point(408, 253);
            frameRegIncome.Name = "frameRegIncome";
            frameRegIncome.Size = new Size(793, 519);
            frameRegIncome.TabIndex = 7;
            // 
            // lblIncomeTitle
            // 
            lblIncomeTitle.AutoSize = true;
            lblIncomeTitle.Font = new Font("Avignon Pro", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIncomeTitle.Location = new Point(214, 12);
            lblIncomeTitle.Name = "lblIncomeTitle";
            lblIncomeTitle.Size = new Size(362, 55);
            lblIncomeTitle.TabIndex = 1;
            lblIncomeTitle.Text = "Register Income";
            // 
            // btnRegisterIncome
            // 
            btnRegisterIncome.Font = new Font("Avignon Pro", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegisterIncome.Location = new Point(10, 425);
            btnRegisterIncome.Name = "btnRegisterIncome";
            btnRegisterIncome.Size = new Size(770, 81);
            btnRegisterIncome.TabIndex = 6;
            btnRegisterIncome.Text = "Register Income";
            btnRegisterIncome.UseVisualStyleBackColor = true;
            btnRegisterIncome.Click += btnRegisterIncome_Click;
            // 
            // numIncomeQuantity
            // 
            numIncomeQuantity.Font = new Font("Avignon Pro", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numIncomeQuantity.Location = new Point(48, 329);
            numIncomeQuantity.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numIncomeQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numIncomeQuantity.Name = "numIncomeQuantity";
            numIncomeQuantity.Size = new Size(704, 63);
            numIncomeQuantity.TabIndex = 5;
            numIncomeQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblIncomeProduct
            // 
            lblIncomeProduct.AutoSize = true;
            lblIncomeProduct.Font = new Font("Avignon Pro", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIncomeProduct.Location = new Point(48, 100);
            lblIncomeProduct.Name = "lblIncomeProduct";
            lblIncomeProduct.Size = new Size(189, 55);
            lblIncomeProduct.TabIndex = 2;
            lblIncomeProduct.Text = "Product";
            // 
            // cmbIncomeProduct
            // 
            cmbIncomeProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIncomeProduct.Font = new Font("Avignon Pro", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbIncomeProduct.FormattingEnabled = true;
            cmbIncomeProduct.Location = new Point(48, 163);
            cmbIncomeProduct.Name = "cmbIncomeProduct";
            cmbIncomeProduct.Size = new Size(704, 63);
            cmbIncomeProduct.TabIndex = 4;
            // 
            // lblIncomeQuantity
            // 
            lblIncomeQuantity.AutoSize = true;
            lblIncomeQuantity.Font = new Font("Avignon Pro", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIncomeQuantity.Location = new Point(48, 270);
            lblIncomeQuantity.Name = "lblIncomeQuantity";
            lblIncomeQuantity.Size = new Size(207, 55);
            lblIncomeQuantity.TabIndex = 3;
            lblIncomeQuantity.Text = "Quantity";
            lblIncomeQuantity.Click += lblIncomeQuantity_Click;
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Font = new Font("Avignon Pro", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIncome.Location = new Point(20, 14);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(114, 34);
            lblIncome.TabIndex = 0;
            lblIncome.Text = "Income";
            // 
            // panelExpense
            // 
            panelExpense.BackColor = SystemColors.Control;
            panelExpense.Controls.Add(lblExpense);
            panelExpense.Controls.Add(frameRegExpense);
            panelExpense.Location = new Point(281, 14);
            panelExpense.Name = "panelExpense";
            panelExpense.Size = new Size(1610, 1015);
            panelExpense.TabIndex = 5;
            panelExpense.Visible = false;
            // 
            // lblExpense
            // 
            lblExpense.AutoSize = true;
            lblExpense.Font = new Font("Avignon Pro", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExpense.Location = new Point(20, 14);
            lblExpense.Name = "lblExpense";
            lblExpense.Size = new Size(122, 34);
            lblExpense.TabIndex = 9;
            lblExpense.Text = "Expense";
            // 
            // frameRegExpense
            // 
            frameRegExpense.BackColor = SystemColors.ControlLight;
            frameRegExpense.Controls.Add(lblExpenseTitle);
            frameRegExpense.Controls.Add(btnRegisterExpense);
            frameRegExpense.Controls.Add(numExpenseQuantity);
            frameRegExpense.Controls.Add(lblExpenseProduct);
            frameRegExpense.Controls.Add(cmbExpenseProduct);
            frameRegExpense.Controls.Add(lblExpenseQuantity);
            frameRegExpense.Location = new Point(408, 253);
            frameRegExpense.Name = "frameRegExpense";
            frameRegExpense.Size = new Size(793, 519);
            frameRegExpense.TabIndex = 8;
            // 
            // lblExpenseTitle
            // 
            lblExpenseTitle.AutoSize = true;
            lblExpenseTitle.Font = new Font("Avignon Pro", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExpenseTitle.Location = new Point(214, 12);
            lblExpenseTitle.Name = "lblExpenseTitle";
            lblExpenseTitle.Size = new Size(375, 55);
            lblExpenseTitle.TabIndex = 1;
            lblExpenseTitle.Text = "Register Expense";
            lblExpenseTitle.Click += lblExpenseTitle_Click;
            // 
            // btnRegisterExpense
            // 
            btnRegisterExpense.Font = new Font("Avignon Pro", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegisterExpense.Location = new Point(10, 425);
            btnRegisterExpense.Name = "btnRegisterExpense";
            btnRegisterExpense.Size = new Size(770, 81);
            btnRegisterExpense.TabIndex = 6;
            btnRegisterExpense.Text = "Register Expense";
            btnRegisterExpense.UseVisualStyleBackColor = true;
            btnRegisterExpense.Click += btnRegisterExpense_Click;
            // 
            // numExpenseQuantity
            // 
            numExpenseQuantity.Font = new Font("Avignon Pro", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numExpenseQuantity.Location = new Point(48, 329);
            numExpenseQuantity.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numExpenseQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numExpenseQuantity.Name = "numExpenseQuantity";
            numExpenseQuantity.Size = new Size(704, 63);
            numExpenseQuantity.TabIndex = 5;
            numExpenseQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblExpenseProduct
            // 
            lblExpenseProduct.AutoSize = true;
            lblExpenseProduct.Font = new Font("Avignon Pro", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExpenseProduct.Location = new Point(48, 100);
            lblExpenseProduct.Name = "lblExpenseProduct";
            lblExpenseProduct.Size = new Size(189, 55);
            lblExpenseProduct.TabIndex = 2;
            lblExpenseProduct.Text = "Product";
            // 
            // cmbExpenseProduct
            // 
            cmbExpenseProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExpenseProduct.Font = new Font("Avignon Pro", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbExpenseProduct.FormattingEnabled = true;
            cmbExpenseProduct.Location = new Point(48, 163);
            cmbExpenseProduct.Name = "cmbExpenseProduct";
            cmbExpenseProduct.Size = new Size(704, 63);
            cmbExpenseProduct.TabIndex = 4;
            // 
            // lblExpenseQuantity
            // 
            lblExpenseQuantity.AutoSize = true;
            lblExpenseQuantity.Font = new Font("Avignon Pro", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExpenseQuantity.Location = new Point(48, 270);
            lblExpenseQuantity.Name = "lblExpenseQuantity";
            lblExpenseQuantity.Size = new Size(207, 55);
            lblExpenseQuantity.TabIndex = 3;
            lblExpenseQuantity.Text = "Quantity";
            lblExpenseQuantity.Click += lblExpenseQuantity_Click;
            // 
            // panelHistory
            // 
            panelHistory.BackColor = Color.Azure;
            panelHistory.Controls.Add(dgvHistory);
            panelHistory.Controls.Add(lblHistory);
            panelHistory.Location = new Point(281, 14);
            panelHistory.Name = "panelHistory";
            panelHistory.Size = new Size(1610, 1015);
            panelHistory.TabIndex = 6;
            panelHistory.Visible = false;
            // 
            // dgvHistory
            // 
            dgvHistory.BackgroundColor = SystemColors.ControlLight;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(20, 60);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.Size = new Size(1566, 932);
            dgvHistory.TabIndex = 1;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Font = new Font("Avignon Pro", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistory.Location = new Point(20, 14);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(97, 34);
            lblHistory.TabIndex = 0;
            lblHistory.Text = "History";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panelProducts);
            Controls.Add(panelMain);
            Controls.Add(panelIncome);
            Controls.Add(panelExpense);
            Controls.Add(panelHistory);
            Controls.Add(panelMenu);
            Controls.Add(lblLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SCS";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOperations).EndInit();
            frameCategories.ResumeLayout(false);
            frameCategories.PerformLayout();
            frameStock.ResumeLayout(false);
            frameStock.PerformLayout();
            frameProducts.ResumeLayout(false);
            frameProducts.PerformLayout();
            panelProducts.ResumeLayout(false);
            panelProducts.PerformLayout();
            frameProductsInfo.ResumeLayout(false);
            frameProductsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panelIncome.ResumeLayout(false);
            panelIncome.PerformLayout();
            frameRegIncome.ResumeLayout(false);
            frameRegIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numIncomeQuantity).EndInit();
            panelExpense.ResumeLayout(false);
            panelExpense.PerformLayout();
            frameRegExpense.ResumeLayout(false);
            frameRegExpense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numExpenseQuantity).EndInit();
            panelHistory.ResumeLayout(false);
            panelHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Panel frameCategories;
        private System.Windows.Forms.Panel frameStock;
        private System.Windows.Forms.Panel frameProducts;
        private System.Windows.Forms.Label lblProductsText;
        private System.Windows.Forms.Label lblProductsCount;
        private System.Windows.Forms.Label lblCategoriesText;
        private System.Windows.Forms.Label lblCategoriesCount;
        private System.Windows.Forms.Label lblLowStockText;
        private System.Windows.Forms.Label lblLowStockCount;
        private System.Windows.Forms.DataGridView dgvOperations;
        private System.Windows.Forms.Label lblOperations;
        private Label lblProductsTitle;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtCategory;
        private TextBox txtProductName;
        private Button btnAddProduct;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblCategory;
        private Label lblProductName;
        private Panel panelProducts;
        private DataGridView dgvProducts;
        private Label lblProductsDGV;
        private Button btnDeleteProduct;
        private Button btnEditProduct;
        private Panel frameProductsInfo;
        private Label lblProductsText2;
        private Label lblProductsCount2;
        private Label lblCategoriesText2;
        private Label lblPriceText2;
        private Button btnSearch;
        private TextBox txtSearch;
        private ComboBox cmbSort;
        private Label lblProducts;
        private Panel panelIncome;
        private Label lblIncome;
        private Button btnRegisterIncome;
        private NumericUpDown numIncomeQuantity;
        private ComboBox cmbIncomeProduct;
        private Label lblIncomeQuantity;
        private Label lblIncomeProduct;
        private Label lblIncomeTitle;
        private Panel frameRegIncome;
        private Panel panelExpense;
        private Panel frameRegExpense;
        private Label lblExpenseTitle;
        private Button btnRegisterExpense;
        private NumericUpDown numExpenseQuantity;
        private Label lblExpenseProduct;
        private ComboBox cmbExpenseProduct;
        private Label lblExpenseQuantity;
        private Label lblExpense;
        private Label lblCategoriesCount2;
        private Label lblPriceCount2;
        private Panel panelHistory;
        private DataGridView dgvHistory;
        private Label lblHistory;
    }
}

