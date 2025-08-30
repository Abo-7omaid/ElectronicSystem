namespace InventorySystem
{
    partial class productForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productForm));
            this.AddProduct_pnl = new CuoreUI.Controls.cuiPanel();
            this.AddProduct_groupbox = new CuoreUI.Controls.cuiGroupBox();
            this.Add_SupplierName_cb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.reset_btn = new CuoreUI.Controls.cuiButton();
            this.addProduct_btn = new CuoreUI.Controls.cuiButton();
            this.Add_productQuantity_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Add_productPrice_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Create_supplierContact_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Create_supplierEmail_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Create_supplierName_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Add_productName_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cuiSeparator2 = new CuoreUI.Controls.cuiSeparator();
            this.inventoryDBDataSet = new InventorySystem.InventoryDBDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new InventorySystem.InventoryDBDataSetTableAdapters.productsTableAdapter();
            this.search_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.date_lbl = new System.Windows.Forms.Label();
            this.saleNum_lbl = new System.Windows.Forms.Label();
            this.cuiLabel6 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            this.product_dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            this.refresh_btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.addPage_btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.UpdatePage_btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.close_btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.AddSupplier_btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.AddProduct_pnl.SuspendLayout();
            this.AddProduct_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.cuiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProduct_pnl
            // 
            this.AddProduct_pnl.AutoScroll = true;
            this.AddProduct_pnl.Controls.Add(this.AddProduct_groupbox);
            this.AddProduct_pnl.Controls.Add(this.cuiSeparator2);
            this.AddProduct_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddProduct_pnl.Location = new System.Drawing.Point(0, 382);
            this.AddProduct_pnl.Name = "AddProduct_pnl";
            this.AddProduct_pnl.OutlineThickness = 1F;
            this.AddProduct_pnl.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.AddProduct_pnl.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.AddProduct_pnl.Rounding = new System.Windows.Forms.Padding(0);
            this.AddProduct_pnl.Size = new System.Drawing.Size(1146, 317);
            this.AddProduct_pnl.TabIndex = 4;
            // 
            // AddProduct_groupbox
            // 
            this.AddProduct_groupbox.BackColor = System.Drawing.Color.Transparent;
            this.AddProduct_groupbox.BorderColor = System.Drawing.Color.Transparent;
            this.AddProduct_groupbox.Content = " Add Product";
            this.AddProduct_groupbox.Controls.Add(this.cuiSeparator1);
            this.AddProduct_groupbox.Controls.Add(this.Add_SupplierName_cb);
            this.AddProduct_groupbox.Controls.Add(this.AddSupplier_btn);
            this.AddProduct_groupbox.Controls.Add(this.reset_btn);
            this.AddProduct_groupbox.Controls.Add(this.Add_productQuantity_txt);
            this.AddProduct_groupbox.Controls.Add(this.addProduct_btn);
            this.AddProduct_groupbox.Controls.Add(this.Add_productPrice_txt);
            this.AddProduct_groupbox.Controls.Add(this.label10);
            this.AddProduct_groupbox.Controls.Add(this.Create_supplierContact_txt);
            this.AddProduct_groupbox.Controls.Add(this.Create_supplierEmail_txt);
            this.AddProduct_groupbox.Controls.Add(this.Create_supplierName_txt);
            this.AddProduct_groupbox.Controls.Add(this.guna2TextBox3);
            this.AddProduct_groupbox.Controls.Add(this.Add_productName_txt);
            this.AddProduct_groupbox.Controls.Add(this.label5);
            this.AddProduct_groupbox.Controls.Add(this.label6);
            this.AddProduct_groupbox.Controls.Add(this.label7);
            this.AddProduct_groupbox.Controls.Add(this.label4);
            this.AddProduct_groupbox.Controls.Add(this.label3);
            this.AddProduct_groupbox.Controls.Add(this.label2);
            this.AddProduct_groupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddProduct_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.AddProduct_groupbox.Location = new System.Drawing.Point(0, 0);
            this.AddProduct_groupbox.Name = "AddProduct_groupbox";
            this.AddProduct_groupbox.Padding = new System.Windows.Forms.Padding(4, 24, 4, 4);
            this.AddProduct_groupbox.Rounding = new System.Windows.Forms.Padding(4);
            this.AddProduct_groupbox.Size = new System.Drawing.Size(1146, 317);
            this.AddProduct_groupbox.TabIndex = 0;
            // 
            // Add_SupplierName_cb
            // 
            this.Add_SupplierName_cb.AutoRoundedCorners = true;
            this.Add_SupplierName_cb.BackColor = System.Drawing.Color.Transparent;
            this.Add_SupplierName_cb.BorderColor = System.Drawing.Color.Black;
            this.Add_SupplierName_cb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Add_SupplierName_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Add_SupplierName_cb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Add_SupplierName_cb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Add_SupplierName_cb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Add_SupplierName_cb.ForeColor = System.Drawing.Color.Black;
            this.Add_SupplierName_cb.ItemHeight = 30;
            this.Add_SupplierName_cb.Location = new System.Drawing.Point(148, 190);
            this.Add_SupplierName_cb.Name = "Add_SupplierName_cb";
            this.Add_SupplierName_cb.Size = new System.Drawing.Size(172, 36);
            this.Add_SupplierName_cb.TabIndex = 5;
            // 
            // reset_btn
            // 
            this.reset_btn.CheckButton = false;
            this.reset_btn.Checked = false;
            this.reset_btn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.reset_btn.CheckedForeColor = System.Drawing.Color.White;
            this.reset_btn.CheckedImageTint = System.Drawing.Color.White;
            this.reset_btn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.reset_btn.Content = "Reset";
            this.reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.Color.White;
            this.reset_btn.HoverBackground = System.Drawing.Color.White;
            this.reset_btn.HoverForeColor = System.Drawing.Color.Black;
            this.reset_btn.HoverImageTint = System.Drawing.Color.White;
            this.reset_btn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reset_btn.Image = null;
            this.reset_btn.ImageAutoCenter = true;
            this.reset_btn.ImageExpand = new System.Drawing.Point(0, 0);
            this.reset_btn.ImageOffset = new System.Drawing.Point(0, 0);
            this.reset_btn.Location = new System.Drawing.Point(628, 236);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reset_btn.NormalForeColor = System.Drawing.Color.White;
            this.reset_btn.NormalImageTint = System.Drawing.Color.White;
            this.reset_btn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reset_btn.OutlineThickness = 1F;
            this.reset_btn.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.reset_btn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.reset_btn.PressedImageTint = System.Drawing.Color.White;
            this.reset_btn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reset_btn.Rounding = new System.Windows.Forms.Padding(8);
            this.reset_btn.Size = new System.Drawing.Size(113, 35);
            this.reset_btn.TabIndex = 200;
            this.reset_btn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.reset_btn.TextOffset = new System.Drawing.Point(0, 0);
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // addProduct_btn
            // 
            this.addProduct_btn.CheckButton = false;
            this.addProduct_btn.Checked = false;
            this.addProduct_btn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.addProduct_btn.CheckedForeColor = System.Drawing.Color.White;
            this.addProduct_btn.CheckedImageTint = System.Drawing.Color.White;
            this.addProduct_btn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.addProduct_btn.Content = "Add Product";
            this.addProduct_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProduct_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addProduct_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_btn.ForeColor = System.Drawing.Color.White;
            this.addProduct_btn.HoverBackground = System.Drawing.Color.White;
            this.addProduct_btn.HoverForeColor = System.Drawing.Color.Black;
            this.addProduct_btn.HoverImageTint = System.Drawing.Color.White;
            this.addProduct_btn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addProduct_btn.Image = null;
            this.addProduct_btn.ImageAutoCenter = true;
            this.addProduct_btn.ImageExpand = new System.Drawing.Point(0, 0);
            this.addProduct_btn.ImageOffset = new System.Drawing.Point(0, 0);
            this.addProduct_btn.Location = new System.Drawing.Point(504, 236);
            this.addProduct_btn.Name = "addProduct_btn";
            this.addProduct_btn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.addProduct_btn.NormalForeColor = System.Drawing.Color.White;
            this.addProduct_btn.NormalImageTint = System.Drawing.Color.White;
            this.addProduct_btn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addProduct_btn.OutlineThickness = 1F;
            this.addProduct_btn.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.addProduct_btn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.addProduct_btn.PressedImageTint = System.Drawing.Color.White;
            this.addProduct_btn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addProduct_btn.Rounding = new System.Windows.Forms.Padding(8);
            this.addProduct_btn.Size = new System.Drawing.Size(113, 35);
            this.addProduct_btn.TabIndex = 6;
            this.addProduct_btn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.addProduct_btn.TextOffset = new System.Drawing.Point(0, 0);
            this.addProduct_btn.Click += new System.EventHandler(this.addProduct_btn_Click_1);
            // 
            // Add_productQuantity_txt
            // 
            this.Add_productQuantity_txt.AutoRoundedCorners = true;
            this.Add_productQuantity_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Add_productQuantity_txt.DefaultText = "";
            this.Add_productQuantity_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Add_productQuantity_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Add_productQuantity_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Add_productQuantity_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Add_productQuantity_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Add_productQuantity_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_productQuantity_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Add_productQuantity_txt.Location = new System.Drawing.Point(148, 93);
            this.Add_productQuantity_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add_productQuantity_txt.Name = "Add_productQuantity_txt";
            this.Add_productQuantity_txt.PlaceholderText = "";
            this.Add_productQuantity_txt.SelectedText = "";
            this.Add_productQuantity_txt.Size = new System.Drawing.Size(172, 41);
            this.Add_productQuantity_txt.TabIndex = 3;
            // 
            // Add_productPrice_txt
            // 
            this.Add_productPrice_txt.AutoRoundedCorners = true;
            this.Add_productPrice_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Add_productPrice_txt.DefaultText = "";
            this.Add_productPrice_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Add_productPrice_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Add_productPrice_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Add_productPrice_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Add_productPrice_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Add_productPrice_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Add_productPrice_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Add_productPrice_txt.Location = new System.Drawing.Point(148, 142);
            this.Add_productPrice_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add_productPrice_txt.Name = "Add_productPrice_txt";
            this.Add_productPrice_txt.PlaceholderText = "";
            this.Add_productPrice_txt.SelectedText = "";
            this.Add_productPrice_txt.Size = new System.Drawing.Size(172, 41);
            this.Add_productPrice_txt.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 21);
            this.label10.TabIndex = 198;
            this.label10.Text = "SUPPLIER NAME:";
            // 
            // Create_supplierContact_txt
            // 
            this.Create_supplierContact_txt.AutoRoundedCorners = true;
            this.Create_supplierContact_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Create_supplierContact_txt.DefaultText = "";
            this.Create_supplierContact_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Create_supplierContact_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Create_supplierContact_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Create_supplierContact_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Create_supplierContact_txt.Enabled = false;
            this.Create_supplierContact_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Create_supplierContact_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_supplierContact_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Create_supplierContact_txt.Location = new System.Drawing.Point(929, 127);
            this.Create_supplierContact_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Create_supplierContact_txt.Name = "Create_supplierContact_txt";
            this.Create_supplierContact_txt.PlaceholderText = "";
            this.Create_supplierContact_txt.SelectedText = "";
            this.Create_supplierContact_txt.Size = new System.Drawing.Size(172, 41);
            this.Create_supplierContact_txt.TabIndex = 9;
            // 
            // Create_supplierEmail_txt
            // 
            this.Create_supplierEmail_txt.AutoRoundedCorners = true;
            this.Create_supplierEmail_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Create_supplierEmail_txt.DefaultText = "";
            this.Create_supplierEmail_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Create_supplierEmail_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Create_supplierEmail_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Create_supplierEmail_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Create_supplierEmail_txt.Enabled = false;
            this.Create_supplierEmail_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Create_supplierEmail_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_supplierEmail_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Create_supplierEmail_txt.Location = new System.Drawing.Point(929, 72);
            this.Create_supplierEmail_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Create_supplierEmail_txt.Name = "Create_supplierEmail_txt";
            this.Create_supplierEmail_txt.PlaceholderText = "";
            this.Create_supplierEmail_txt.SelectedText = "";
            this.Create_supplierEmail_txt.Size = new System.Drawing.Size(172, 41);
            this.Create_supplierEmail_txt.TabIndex = 8;
            // 
            // Create_supplierName_txt
            // 
            this.Create_supplierName_txt.AutoRoundedCorners = true;
            this.Create_supplierName_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Create_supplierName_txt.DefaultText = "";
            this.Create_supplierName_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Create_supplierName_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Create_supplierName_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Create_supplierName_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Create_supplierName_txt.Enabled = false;
            this.Create_supplierName_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Create_supplierName_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_supplierName_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Create_supplierName_txt.Location = new System.Drawing.Point(929, 23);
            this.Create_supplierName_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Create_supplierName_txt.Name = "Create_supplierName_txt";
            this.Create_supplierName_txt.PlaceholderText = "";
            this.Create_supplierName_txt.SelectedText = "";
            this.Create_supplierName_txt.Size = new System.Drawing.Size(172, 41);
            this.Create_supplierName_txt.TabIndex = 7;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.AutoRoundedCorners = true;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(173, 376);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(303, 41);
            this.guna2TextBox3.TabIndex = 193;
            // 
            // Add_productName_txt
            // 
            this.Add_productName_txt.AutoRoundedCorners = true;
            this.Add_productName_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Add_productName_txt.DefaultText = "";
            this.Add_productName_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Add_productName_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Add_productName_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Add_productName_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Add_productName_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Add_productName_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_productName_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Add_productName_txt.Location = new System.Drawing.Point(151, 38);
            this.Add_productName_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add_productName_txt.Name = "Add_productName_txt";
            this.Add_productName_txt.PlaceholderText = "";
            this.Add_productName_txt.SelectedText = "";
            this.Add_productName_txt.Size = new System.Drawing.Size(169, 41);
            this.Add_productName_txt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(794, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 176;
            this.label5.Text = "CONTACT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(794, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 21);
            this.label6.TabIndex = 174;
            this.label6.Text = "SUPPLIER EMAIL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(794, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 21);
            this.label7.TabIndex = 173;
            this.label7.Text = "SUPPLIER NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 168;
            this.label4.Text = "PRICE PER UNIT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 166;
            this.label3.Text = "QUNATITY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 164;
            this.label2.Text = "PRODUCT NAME:";
            // 
            // cuiSeparator2
            // 
            this.cuiSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiSeparator2.Location = new System.Drawing.Point(129, -23);
            this.cuiSeparator2.Margin = new System.Windows.Forms.Padding(6);
            this.cuiSeparator2.Name = "cuiSeparator2";
            this.cuiSeparator2.SeparatorMargin = 8;
            this.cuiSeparator2.Size = new System.Drawing.Size(417, 15);
            this.cuiSeparator2.TabIndex = 187;
            this.cuiSeparator2.Thickness = 0.5F;
            this.cuiSeparator2.Vertical = false;
            // 
            // inventoryDBDataSet
            // 
            this.inventoryDBDataSet.DataSetName = "InventoryDBDataSet";
            this.inventoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.inventoryDBDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // search_txt
            // 
            this.search_txt.AutoRoundedCorners = true;
            this.search_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_txt.DefaultText = "";
            this.search_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_txt.Location = new System.Drawing.Point(414, 329);
            this.search_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_txt.Name = "search_txt";
            this.search_txt.PlaceholderText = "";
            this.search_txt.SelectedText = "";
            this.search_txt.Size = new System.Drawing.Size(283, 41);
            this.search_txt.TabIndex = 1;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel2.Controls.Add(this.close_btn);
            this.cuiPanel2.Controls.Add(this.date_lbl);
            this.cuiPanel2.Controls.Add(this.saleNum_lbl);
            this.cuiPanel2.Controls.Add(this.cuiLabel6);
            this.cuiPanel2.Controls.Add(this.cuiLabel5);
            this.cuiPanel2.Controls.Add(this.cuiLabel4);
            this.cuiPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.cuiPanel2.Location = new System.Drawing.Point(0, 24);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 0F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPanel2.Size = new System.Drawing.Size(1146, 66);
            this.cuiPanel2.TabIndex = 1;
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.BackColor = System.Drawing.Color.Transparent;
            this.date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.date_lbl.Location = new System.Drawing.Point(837, 43);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(44, 16);
            this.date_lbl.TabIndex = 19;
            this.date_lbl.Text = "- /- / -";
            // 
            // saleNum_lbl
            // 
            this.saleNum_lbl.AutoSize = true;
            this.saleNum_lbl.BackColor = System.Drawing.Color.Transparent;
            this.saleNum_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleNum_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saleNum_lbl.Location = new System.Drawing.Point(837, 12);
            this.saleNum_lbl.Name = "saleNum_lbl";
            this.saleNum_lbl.Size = new System.Drawing.Size(31, 16);
            this.saleNum_lbl.TabIndex = 18;
            this.saleNum_lbl.Text = "000";
            // 
            // cuiLabel6
            // 
            this.cuiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel6.Content = "Date:";
            this.cuiLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel6.ForeColor = System.Drawing.Color.White;
            this.cuiLabel6.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel6.Location = new System.Drawing.Point(721, 37);
            this.cuiLabel6.Name = "cuiLabel6";
            this.cuiLabel6.Size = new System.Drawing.Size(135, 26);
            this.cuiLabel6.TabIndex = 17;
            this.cuiLabel6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel5
            // 
            this.cuiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel5.Content = "Sales\\ No:";
            this.cuiLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel5.ForeColor = System.Drawing.Color.White;
            this.cuiLabel5.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel5.Location = new System.Drawing.Point(721, 0);
            this.cuiLabel5.Name = "cuiLabel5";
            this.cuiLabel5.Size = new System.Drawing.Size(135, 40);
            this.cuiLabel5.TabIndex = 16;
            this.cuiLabel5.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel4
            // 
            this.cuiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel4.Content = "Products\\ Form";
            this.cuiLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel4.ForeColor = System.Drawing.Color.White;
            this.cuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel4.Location = new System.Drawing.Point(59, 9);
            this.cuiLabel4.Name = "cuiLabel4";
            this.cuiLabel4.Size = new System.Drawing.Size(164, 40);
            this.cuiLabel4.TabIndex = 1;
            this.cuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // product_dgv
            // 
            this.product_dgv.AllowUserToAddRows = false;
            this.product_dgv.AllowUserToDeleteRows = false;
            this.product_dgv.AllowUserToOrderColumns = true;
            this.product_dgv.AllowUserToResizeColumns = false;
            this.product_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.product_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.product_dgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.product_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.product_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.product_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.product_dgv.ColumnHeadersHeight = 20;
            this.product_dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.product_dgv.DefaultCellStyle = dataGridViewCellStyle12;
            this.product_dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.product_dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.product_dgv.EnableHeadersVisualStyles = true;
            this.product_dgv.GridColor = System.Drawing.Color.Black;
            this.product_dgv.Location = new System.Drawing.Point(0, 90);
            this.product_dgv.Name = "product_dgv";
            this.product_dgv.ReadOnly = true;
            this.product_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.product_dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.product_dgv.Size = new System.Drawing.Size(1146, 230);
            this.product_dgv.TabIndex = 166;
            this.product_dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.product_dgv.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.product_dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.product_dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.product_dgv.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.product_dgv.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.product_dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.product_dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.product_dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.product_dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.product_dgv.ThemeStyle.HeaderStyle.Height = 20;
            this.product_dgv.ThemeStyle.ReadOnly = true;
            this.product_dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.product_dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.product_dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.product_dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.product_dgv.ThemeStyle.RowsStyle.Height = 22;
            this.product_dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.product_dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.product_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_dgv_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1146, 24);
            this.menuStrip1.TabIndex = 167;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuiSeparator1
            // 
            this.cuiSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cuiSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiSeparator1.Location = new System.Drawing.Point(766, 13);
            this.cuiSeparator1.Margin = new System.Windows.Forms.Padding(6);
            this.cuiSeparator1.Name = "cuiSeparator1";
            this.cuiSeparator1.SeparatorMargin = 8;
            this.cuiSeparator1.Size = new System.Drawing.Size(10, 258);
            this.cuiSeparator1.TabIndex = 203;
            this.cuiSeparator1.Thickness = 0.5F;
            this.cuiSeparator1.Vertical = false;
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.Transparent;
            this.refresh_btn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.refresh_btn.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.refresh_btn.Image = global::InventorySystem.Properties.Resources.icons8_refresh_64;
            this.refresh_btn.ImageOffset = new System.Drawing.Point(0, 0);
            this.refresh_btn.ImageRotate = 0F;
            this.refresh_btn.ImageSize = new System.Drawing.Size(55, 55);
            this.refresh_btn.Location = new System.Drawing.Point(148, 333);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.refresh_btn.Size = new System.Drawing.Size(52, 43);
            this.refresh_btn.TabIndex = 170;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // addPage_btn
            // 
            this.addPage_btn.BackColor = System.Drawing.Color.Transparent;
            this.addPage_btn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.addPage_btn.HoverState.ImageSize = new System.Drawing.Size(55, 55);
            this.addPage_btn.Image = global::InventorySystem.Properties.Resources.icons8_add_new_64;
            this.addPage_btn.ImageOffset = new System.Drawing.Point(0, 0);
            this.addPage_btn.ImageRotate = 0F;
            this.addPage_btn.ImageSize = new System.Drawing.Size(50, 50);
            this.addPage_btn.Location = new System.Drawing.Point(14, 333);
            this.addPage_btn.Name = "addPage_btn";
            this.addPage_btn.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.addPage_btn.Size = new System.Drawing.Size(52, 43);
            this.addPage_btn.TabIndex = 169;
            this.addPage_btn.Click += new System.EventHandler(this.addPage_btn_Click);
            // 
            // UpdatePage_btn
            // 
            this.UpdatePage_btn.BackColor = System.Drawing.Color.Transparent;
            this.UpdatePage_btn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.UpdatePage_btn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.UpdatePage_btn.Image = global::InventorySystem.Properties.Resources.icons8_edit_64;
            this.UpdatePage_btn.ImageOffset = new System.Drawing.Point(0, 0);
            this.UpdatePage_btn.ImageRotate = 0F;
            this.UpdatePage_btn.ImageSize = new System.Drawing.Size(60, 60);
            this.UpdatePage_btn.Location = new System.Drawing.Point(72, 333);
            this.UpdatePage_btn.Name = "UpdatePage_btn";
            this.UpdatePage_btn.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.UpdatePage_btn.Size = new System.Drawing.Size(52, 43);
            this.UpdatePage_btn.TabIndex = 168;
            this.UpdatePage_btn.Click += new System.EventHandler(this.UpdatePage_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.close_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_btn.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.close_btn.Image = global::InventorySystem.Properties.Resources.icons8_close_window_94;
            this.close_btn.ImageOffset = new System.Drawing.Point(0, 0);
            this.close_btn.ImageRotate = 0F;
            this.close_btn.ImageSize = new System.Drawing.Size(35, 35);
            this.close_btn.Location = new System.Drawing.Point(1064, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.close_btn.Size = new System.Drawing.Size(82, 66);
            this.close_btn.TabIndex = 20;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // AddSupplier_btn
            // 
            this.AddSupplier_btn.BackColor = System.Drawing.Color.Transparent;
            this.AddSupplier_btn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.AddSupplier_btn.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.AddSupplier_btn.Image = global::InventorySystem.Properties.Resources.icons8_add_64;
            this.AddSupplier_btn.ImageOffset = new System.Drawing.Point(0, 0);
            this.AddSupplier_btn.ImageRotate = 0F;
            this.AddSupplier_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.AddSupplier_btn.Location = new System.Drawing.Point(362, 184);
            this.AddSupplier_btn.Name = "AddSupplier_btn";
            this.AddSupplier_btn.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.AddSupplier_btn.Size = new System.Drawing.Size(41, 42);
            this.AddSupplier_btn.TabIndex = 201;
            this.AddSupplier_btn.Click += new System.EventHandler(this.AddSupplier_btn_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.Location = new System.Drawing.Point(703, 329);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.Size = new System.Drawing.Size(52, 43);
            this.guna2ImageButton1.TabIndex = 3;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // productForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1146, 699);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.addPage_btn);
            this.Controls.Add(this.UpdatePage_btn);
            this.Controls.Add(this.product_dgv);
            this.Controls.Add(this.cuiPanel2);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.AddProduct_pnl);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "productForm";
            this.Text = "productForm";
            this.Load += new System.EventHandler(this.productForm_Load);
            this.AddProduct_pnl.ResumeLayout(false);
            this.AddProduct_groupbox.ResumeLayout(false);
            this.AddProduct_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.cuiPanel2.ResumeLayout(false);
            this.cuiPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private CuoreUI.Controls.cuiPanel AddProduct_pnl;
        private CuoreUI.Controls.cuiGroupBox AddProduct_groupbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private CuoreUI.Controls.cuiSeparator cuiSeparator2;
        private InventoryDBDataSet inventoryDBDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private InventoryDBDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox Add_productPrice_txt;
        private Guna.UI2.WinForms.Guna2TextBox Add_productName_txt;
        private Guna.UI2.WinForms.Guna2TextBox Create_supplierContact_txt;
        private Guna.UI2.WinForms.Guna2TextBox Create_supplierEmail_txt;
        private Guna.UI2.WinForms.Guna2TextBox Create_supplierName_txt;
        private Guna.UI2.WinForms.Guna2TextBox Add_productQuantity_txt;
        private Guna.UI2.WinForms.Guna2TextBox search_txt;
        private CuoreUI.Controls.cuiButton addProduct_btn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CuoreUI.Controls.cuiButton reset_btn;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ImageButton AddSupplier_btn;
        private Guna.UI2.WinForms.Guna2ComboBox Add_SupplierName_cb;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private Guna.UI2.WinForms.Guna2ImageButton close_btn;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label saleNum_lbl;
        private CuoreUI.Controls.cuiLabel cuiLabel6;
        private CuoreUI.Controls.cuiLabel cuiLabel5;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private Guna.UI2.WinForms.Guna2DataGridView product_dgv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private Guna.UI2.WinForms.Guna2ImageButton UpdatePage_btn;
        private Guna.UI2.WinForms.Guna2ImageButton addPage_btn;
        private Guna.UI2.WinForms.Guna2ImageButton refresh_btn;
    }
}