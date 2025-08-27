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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productForm));
            this.TEST_BTN = new CuoreUI.Controls.cuiButton();
            this.product_dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            this.cuiGroupBox2 = new CuoreUI.Controls.cuiGroupBox();
            this.delete_btn = new CuoreUI.Controls.cuiButton();
            this.update_btn = new CuoreUI.Controls.cuiButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cuiGroupBox1 = new CuoreUI.Controls.cuiGroupBox();
            this.cuiSeparator2 = new CuoreUI.Controls.cuiSeparator();
            this.reset_btn = new CuoreUI.Controls.cuiButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.inventoryDBDataSet = new InventorySystem.InventoryDBDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new InventorySystem.InventoryDBDataSetTableAdapters.productsTableAdapter();
            this.Add_productName_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Add_productPrice_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.search_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Add_productQuantity_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.supplierContact_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.supplierEmail_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.supplierName_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.upd_productPrice_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.upd_productQuantity_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.upd_productName_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.addProduct_btn = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)(this.product_dgv)).BeginInit();
            this.cuiPanel1.SuspendLayout();
            this.cuiGroupBox2.SuspendLayout();
            this.cuiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TEST_BTN
            // 
            this.TEST_BTN.CheckButton = false;
            this.TEST_BTN.Checked = false;
            this.TEST_BTN.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TEST_BTN.CheckedForeColor = System.Drawing.Color.White;
            this.TEST_BTN.CheckedImageTint = System.Drawing.Color.White;
            this.TEST_BTN.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TEST_BTN.Content = "Your text here!";
            this.TEST_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TEST_BTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.TEST_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TEST_BTN.ForeColor = System.Drawing.Color.Black;
            this.TEST_BTN.HoverBackground = System.Drawing.Color.White;
            this.TEST_BTN.HoverForeColor = System.Drawing.Color.Black;
            this.TEST_BTN.HoverImageTint = System.Drawing.Color.White;
            this.TEST_BTN.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TEST_BTN.Image = null;
            this.TEST_BTN.ImageAutoCenter = true;
            this.TEST_BTN.ImageExpand = new System.Drawing.Point(0, 0);
            this.TEST_BTN.ImageOffset = new System.Drawing.Point(0, 0);
            this.TEST_BTN.Location = new System.Drawing.Point(802, 273);
            this.TEST_BTN.Name = "TEST_BTN";
            this.TEST_BTN.NormalBackground = System.Drawing.Color.White;
            this.TEST_BTN.NormalForeColor = System.Drawing.Color.Black;
            this.TEST_BTN.NormalImageTint = System.Drawing.Color.White;
            this.TEST_BTN.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TEST_BTN.OutlineThickness = 1F;
            this.TEST_BTN.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.TEST_BTN.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TEST_BTN.PressedImageTint = System.Drawing.Color.White;
            this.TEST_BTN.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TEST_BTN.Rounding = new System.Windows.Forms.Padding(20);
            this.TEST_BTN.Size = new System.Drawing.Size(272, 40);
            this.TEST_BTN.TabIndex = 0;
            this.TEST_BTN.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TEST_BTN.TextOffset = new System.Drawing.Point(0, 0);
            this.TEST_BTN.Click += new System.EventHandler(this.cuiButton1_Click);
            // 
            // product_dgv
            // 
            this.product_dgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.product_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.product_dgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.product_dgv.ColumnHeadersHeight = 4;
            this.product_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.product_dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.product_dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.product_dgv.GridColor = System.Drawing.Color.Black;
            this.product_dgv.Location = new System.Drawing.Point(0, 0);
            this.product_dgv.Name = "product_dgv";
            this.product_dgv.RowHeadersVisible = false;
            this.product_dgv.Size = new System.Drawing.Size(1146, 252);
            this.product_dgv.TabIndex = 1;
            this.product_dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.product_dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.product_dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.product_dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.product_dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.product_dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.product_dgv.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.product_dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.product_dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.product_dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.product_dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.product_dgv.ThemeStyle.HeaderStyle.Height = 4;
            this.product_dgv.ThemeStyle.ReadOnly = false;
            this.product_dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.product_dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.product_dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.product_dgv.ThemeStyle.RowsStyle.Height = 22;
            this.product_dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.product_dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.cuiSeparator1);
            this.cuiPanel1.Controls.Add(this.cuiGroupBox2);
            this.cuiPanel1.Controls.Add(this.cuiGroupBox1);
            this.cuiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cuiPanel1.Location = new System.Drawing.Point(0, 325);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.Black;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPanel1.Size = new System.Drawing.Size(1146, 374);
            this.cuiPanel1.TabIndex = 4;
            // 
            // cuiSeparator1
            // 
            this.cuiSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiSeparator1.Location = new System.Drawing.Point(606, 9);
            this.cuiSeparator1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cuiSeparator1.Name = "cuiSeparator1";
            this.cuiSeparator1.SeparatorMargin = 8;
            this.cuiSeparator1.Size = new System.Drawing.Size(29, 360);
            this.cuiSeparator1.TabIndex = 188;
            this.cuiSeparator1.Thickness = 0.5F;
            this.cuiSeparator1.Vertical = true;
            // 
            // cuiGroupBox2
            // 
            this.cuiGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.cuiGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.cuiGroupBox2.Content = "Update \\Delete Product";
            this.cuiGroupBox2.Controls.Add(this.upd_productPrice_txt);
            this.cuiGroupBox2.Controls.Add(this.upd_productQuantity_txt);
            this.cuiGroupBox2.Controls.Add(this.upd_productName_txt);
            this.cuiGroupBox2.Controls.Add(this.delete_btn);
            this.cuiGroupBox2.Controls.Add(this.update_btn);
            this.cuiGroupBox2.Controls.Add(this.label1);
            this.cuiGroupBox2.Controls.Add(this.label8);
            this.cuiGroupBox2.Controls.Add(this.label9);
            this.cuiGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiGroupBox2.Location = new System.Drawing.Point(621, 9);
            this.cuiGroupBox2.Name = "cuiGroupBox2";
            this.cuiGroupBox2.Padding = new System.Windows.Forms.Padding(4, 19, 4, 4);
            this.cuiGroupBox2.Rounding = new System.Windows.Forms.Padding(4);
            this.cuiGroupBox2.Size = new System.Drawing.Size(519, 358);
            this.cuiGroupBox2.TabIndex = 1;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Transparent;
            this.delete_btn.CheckButton = false;
            this.delete_btn.Checked = false;
            this.delete_btn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.delete_btn.CheckedForeColor = System.Drawing.Color.White;
            this.delete_btn.CheckedImageTint = System.Drawing.Color.White;
            this.delete_btn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.delete_btn.Content = "DELETE";
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.HoverBackground = System.Drawing.Color.White;
            this.delete_btn.HoverForeColor = System.Drawing.Color.Black;
            this.delete_btn.HoverImageTint = System.Drawing.Color.White;
            this.delete_btn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete_btn.Image = null;
            this.delete_btn.ImageAutoCenter = true;
            this.delete_btn.ImageExpand = new System.Drawing.Point(0, 0);
            this.delete_btn.ImageOffset = new System.Drawing.Point(0, 0);
            this.delete_btn.Location = new System.Drawing.Point(330, 200);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.NormalBackground = System.Drawing.Color.Red;
            this.delete_btn.NormalForeColor = System.Drawing.Color.Black;
            this.delete_btn.NormalImageTint = System.Drawing.Color.White;
            this.delete_btn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete_btn.OutlineThickness = 1F;
            this.delete_btn.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.delete_btn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.delete_btn.PressedImageTint = System.Drawing.Color.White;
            this.delete_btn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete_btn.Rounding = new System.Windows.Forms.Padding(20);
            this.delete_btn.Size = new System.Drawing.Size(123, 40);
            this.delete_btn.TabIndex = 200;
            this.delete_btn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.delete_btn.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Transparent;
            this.update_btn.CheckButton = false;
            this.update_btn.Checked = false;
            this.update_btn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.update_btn.CheckedForeColor = System.Drawing.Color.White;
            this.update_btn.CheckedImageTint = System.Drawing.Color.White;
            this.update_btn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.update_btn.Content = "UPDATE";
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.update_btn.ForeColor = System.Drawing.Color.Black;
            this.update_btn.HoverBackground = System.Drawing.Color.White;
            this.update_btn.HoverForeColor = System.Drawing.Color.Black;
            this.update_btn.HoverImageTint = System.Drawing.Color.White;
            this.update_btn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.update_btn.Image = null;
            this.update_btn.ImageAutoCenter = true;
            this.update_btn.ImageExpand = new System.Drawing.Point(0, 0);
            this.update_btn.ImageOffset = new System.Drawing.Point(0, 0);
            this.update_btn.Location = new System.Drawing.Point(168, 200);
            this.update_btn.Name = "update_btn";
            this.update_btn.NormalBackground = System.Drawing.Color.LimeGreen;
            this.update_btn.NormalForeColor = System.Drawing.Color.Black;
            this.update_btn.NormalImageTint = System.Drawing.Color.White;
            this.update_btn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.update_btn.OutlineThickness = 1F;
            this.update_btn.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.update_btn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.update_btn.PressedImageTint = System.Drawing.Color.White;
            this.update_btn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.update_btn.Rounding = new System.Windows.Forms.Padding(20);
            this.update_btn.Size = new System.Drawing.Size(123, 40);
            this.update_btn.TabIndex = 199;
            this.update_btn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.update_btn.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 196;
            this.label1.Text = "PRICE PER UNIT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 21);
            this.label8.TabIndex = 194;
            this.label8.Text = "QUNATITY:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 21);
            this.label9.TabIndex = 193;
            this.label9.Text = "PRODUCT NAME:";
            // 
            // cuiGroupBox1
            // 
            this.cuiGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.cuiGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.cuiGroupBox1.Content = " Add Product";
            this.cuiGroupBox1.Controls.Add(this.addProduct_btn);
            this.cuiGroupBox1.Controls.Add(this.supplierContact_txt);
            this.cuiGroupBox1.Controls.Add(this.supplierEmail_txt);
            this.cuiGroupBox1.Controls.Add(this.supplierName_txt);
            this.cuiGroupBox1.Controls.Add(this.Add_productQuantity_txt);
            this.cuiGroupBox1.Controls.Add(this.guna2TextBox3);
            this.cuiGroupBox1.Controls.Add(this.Add_productPrice_txt);
            this.cuiGroupBox1.Controls.Add(this.Add_productName_txt);
            this.cuiGroupBox1.Controls.Add(this.cuiSeparator2);
            this.cuiGroupBox1.Controls.Add(this.reset_btn);
            this.cuiGroupBox1.Controls.Add(this.label5);
            this.cuiGroupBox1.Controls.Add(this.label6);
            this.cuiGroupBox1.Controls.Add(this.label7);
            this.cuiGroupBox1.Controls.Add(this.label4);
            this.cuiGroupBox1.Controls.Add(this.label3);
            this.cuiGroupBox1.Controls.Add(this.label2);
            this.cuiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cuiGroupBox1.Location = new System.Drawing.Point(14, 9);
            this.cuiGroupBox1.Name = "cuiGroupBox1";
            this.cuiGroupBox1.Padding = new System.Windows.Forms.Padding(4, 19, 4, 4);
            this.cuiGroupBox1.Rounding = new System.Windows.Forms.Padding(4);
            this.cuiGroupBox1.Size = new System.Drawing.Size(590, 359);
            this.cuiGroupBox1.TabIndex = 0;
            // 
            // cuiSeparator2
            // 
            this.cuiSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiSeparator2.Location = new System.Drawing.Point(0, 187);
            this.cuiSeparator2.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cuiSeparator2.Name = "cuiSeparator2";
            this.cuiSeparator2.SeparatorMargin = 8;
            this.cuiSeparator2.Size = new System.Drawing.Size(434, 21);
            this.cuiSeparator2.TabIndex = 187;
            this.cuiSeparator2.Thickness = 0.5F;
            this.cuiSeparator2.Vertical = false;
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.Transparent;
            this.reset_btn.CheckButton = false;
            this.reset_btn.Checked = false;
            this.reset_btn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.reset_btn.CheckedForeColor = System.Drawing.Color.White;
            this.reset_btn.CheckedImageTint = System.Drawing.Color.White;
            this.reset_btn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.reset_btn.Content = "RESET";
            this.reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.reset_btn.ForeColor = System.Drawing.Color.Black;
            this.reset_btn.HoverBackground = System.Drawing.Color.White;
            this.reset_btn.HoverForeColor = System.Drawing.Color.Black;
            this.reset_btn.HoverImageTint = System.Drawing.Color.White;
            this.reset_btn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reset_btn.Image = null;
            this.reset_btn.ImageAutoCenter = true;
            this.reset_btn.ImageExpand = new System.Drawing.Point(0, 0);
            this.reset_btn.ImageOffset = new System.Drawing.Point(0, 0);
            this.reset_btn.Location = new System.Drawing.Point(445, 95);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.NormalBackground = System.Drawing.Color.Red;
            this.reset_btn.NormalForeColor = System.Drawing.Color.Black;
            this.reset_btn.NormalImageTint = System.Drawing.Color.White;
            this.reset_btn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reset_btn.OutlineThickness = 1F;
            this.reset_btn.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.reset_btn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.reset_btn.PressedImageTint = System.Drawing.Color.White;
            this.reset_btn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reset_btn.Rounding = new System.Windows.Forms.Padding(20);
            this.reset_btn.Size = new System.Drawing.Size(123, 40);
            this.reset_btn.TabIndex = 178;
            this.reset_btn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.reset_btn.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 176;
            this.label5.Text = "CONTACT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 174;
            this.label6.Text = "EMAIL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 21);
            this.label7.TabIndex = 173;
            this.label7.Text = "SUPPLIER NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 168;
            this.label4.Text = "PRICE PER UNIT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 166;
            this.label3.Text = "QUNATITY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 164;
            this.label2.Text = "PRODUCT NAME:";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.Location = new System.Drawing.Point(718, 273);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(52, 43);
            this.guna2ImageButton1.TabIndex = 3;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
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
            this.Add_productName_txt.Location = new System.Drawing.Point(152, 37);
            this.Add_productName_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add_productName_txt.Name = "Add_productName_txt";
            this.Add_productName_txt.PlaceholderText = "";
            this.Add_productName_txt.SelectedText = "";
            this.Add_productName_txt.Size = new System.Drawing.Size(267, 41);
            this.Add_productName_txt.TabIndex = 188;
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
            this.Add_productPrice_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_productPrice_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Add_productPrice_txt.Location = new System.Drawing.Point(152, 86);
            this.Add_productPrice_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add_productPrice_txt.Name = "Add_productPrice_txt";
            this.Add_productPrice_txt.PlaceholderText = "";
            this.Add_productPrice_txt.SelectedText = "";
            this.Add_productPrice_txt.Size = new System.Drawing.Size(267, 41);
            this.Add_productPrice_txt.TabIndex = 189;
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
            this.search_txt.Location = new System.Drawing.Point(413, 267);
            this.search_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_txt.Name = "search_txt";
            this.search_txt.PlaceholderText = "";
            this.search_txt.SelectedText = "";
            this.search_txt.Size = new System.Drawing.Size(283, 41);
            this.search_txt.TabIndex = 190;
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
            this.Add_productQuantity_txt.Location = new System.Drawing.Point(152, 135);
            this.Add_productQuantity_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add_productQuantity_txt.Name = "Add_productQuantity_txt";
            this.Add_productQuantity_txt.PlaceholderText = "";
            this.Add_productQuantity_txt.SelectedText = "";
            this.Add_productQuantity_txt.Size = new System.Drawing.Size(267, 41);
            this.Add_productQuantity_txt.TabIndex = 194;
            // 
            // supplierContact_txt
            // 
            this.supplierContact_txt.AutoRoundedCorners = true;
            this.supplierContact_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supplierContact_txt.DefaultText = "";
            this.supplierContact_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.supplierContact_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.supplierContact_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supplierContact_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supplierContact_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierContact_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierContact_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierContact_txt.Location = new System.Drawing.Point(152, 315);
            this.supplierContact_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supplierContact_txt.Name = "supplierContact_txt";
            this.supplierContact_txt.PlaceholderText = "";
            this.supplierContact_txt.SelectedText = "";
            this.supplierContact_txt.Size = new System.Drawing.Size(267, 41);
            this.supplierContact_txt.TabIndex = 197;
            // 
            // supplierEmail_txt
            // 
            this.supplierEmail_txt.AutoRoundedCorners = true;
            this.supplierEmail_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supplierEmail_txt.DefaultText = "";
            this.supplierEmail_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.supplierEmail_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.supplierEmail_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supplierEmail_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supplierEmail_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierEmail_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierEmail_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierEmail_txt.Location = new System.Drawing.Point(152, 266);
            this.supplierEmail_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supplierEmail_txt.Name = "supplierEmail_txt";
            this.supplierEmail_txt.PlaceholderText = "";
            this.supplierEmail_txt.SelectedText = "";
            this.supplierEmail_txt.Size = new System.Drawing.Size(267, 41);
            this.supplierEmail_txt.TabIndex = 196;
            // 
            // supplierName_txt
            // 
            this.supplierName_txt.AutoRoundedCorners = true;
            this.supplierName_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supplierName_txt.DefaultText = "";
            this.supplierName_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.supplierName_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.supplierName_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supplierName_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supplierName_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierName_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierName_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierName_txt.Location = new System.Drawing.Point(152, 217);
            this.supplierName_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supplierName_txt.Name = "supplierName_txt";
            this.supplierName_txt.PlaceholderText = "";
            this.supplierName_txt.SelectedText = "";
            this.supplierName_txt.Size = new System.Drawing.Size(267, 41);
            this.supplierName_txt.TabIndex = 195;
            // 
            // upd_productPrice_txt
            // 
            this.upd_productPrice_txt.AutoRoundedCorners = true;
            this.upd_productPrice_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upd_productPrice_txt.DefaultText = "";
            this.upd_productPrice_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.upd_productPrice_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.upd_productPrice_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.upd_productPrice_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.upd_productPrice_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.upd_productPrice_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upd_productPrice_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.upd_productPrice_txt.Location = new System.Drawing.Point(229, 135);
            this.upd_productPrice_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.upd_productPrice_txt.Name = "upd_productPrice_txt";
            this.upd_productPrice_txt.PlaceholderText = "";
            this.upd_productPrice_txt.SelectedText = "";
            this.upd_productPrice_txt.Size = new System.Drawing.Size(267, 41);
            this.upd_productPrice_txt.TabIndex = 203;
            // 
            // upd_productQuantity_txt
            // 
            this.upd_productQuantity_txt.AutoRoundedCorners = true;
            this.upd_productQuantity_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upd_productQuantity_txt.DefaultText = "";
            this.upd_productQuantity_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.upd_productQuantity_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.upd_productQuantity_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.upd_productQuantity_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.upd_productQuantity_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.upd_productQuantity_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upd_productQuantity_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.upd_productQuantity_txt.Location = new System.Drawing.Point(229, 86);
            this.upd_productQuantity_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.upd_productQuantity_txt.Name = "upd_productQuantity_txt";
            this.upd_productQuantity_txt.PlaceholderText = "";
            this.upd_productQuantity_txt.SelectedText = "";
            this.upd_productQuantity_txt.Size = new System.Drawing.Size(267, 41);
            this.upd_productQuantity_txt.TabIndex = 202;
            // 
            // upd_productName_txt
            // 
            this.upd_productName_txt.AutoRoundedCorners = true;
            this.upd_productName_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upd_productName_txt.DefaultText = "";
            this.upd_productName_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.upd_productName_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.upd_productName_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.upd_productName_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.upd_productName_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.upd_productName_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upd_productName_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.upd_productName_txt.Location = new System.Drawing.Point(229, 37);
            this.upd_productName_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.upd_productName_txt.Name = "upd_productName_txt";
            this.upd_productName_txt.PlaceholderText = "";
            this.upd_productName_txt.SelectedText = "";
            this.upd_productName_txt.Size = new System.Drawing.Size(267, 41);
            this.upd_productName_txt.TabIndex = 201;
            // 
            // addProduct_btn
            // 
            this.addProduct_btn.CheckButton = false;
            this.addProduct_btn.Checked = false;
            this.addProduct_btn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.addProduct_btn.CheckedForeColor = System.Drawing.Color.White;
            this.addProduct_btn.CheckedImageTint = System.Drawing.Color.White;
            this.addProduct_btn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.addProduct_btn.Content = "Add Item";
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
            this.addProduct_btn.Location = new System.Drawing.Point(459, 41);
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
            this.addProduct_btn.Size = new System.Drawing.Size(94, 35);
            this.addProduct_btn.TabIndex = 198;
            this.addProduct_btn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.addProduct_btn.TextOffset = new System.Drawing.Point(0, 0);
            this.addProduct_btn.Click += new System.EventHandler(this.addProduct_btn_Click_1);
            // 
            // productForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 699);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.cuiPanel1);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.product_dgv);
            this.Controls.Add(this.TEST_BTN);
            this.Name = "productForm";
            this.Text = "productForm";
            this.Load += new System.EventHandler(this.productForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_dgv)).EndInit();
            this.cuiPanel1.ResumeLayout(false);
            this.cuiGroupBox2.ResumeLayout(false);
            this.cuiGroupBox2.PerformLayout();
            this.cuiGroupBox1.ResumeLayout(false);
            this.cuiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiButton TEST_BTN;
        private Guna.UI2.WinForms.Guna2DataGridView product_dgv;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiGroupBox cuiGroupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private CuoreUI.Controls.cuiButton reset_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private CuoreUI.Controls.cuiSeparator cuiSeparator2;
        private CuoreUI.Controls.cuiGroupBox cuiGroupBox2;
        private CuoreUI.Controls.cuiButton delete_btn;
        private CuoreUI.Controls.cuiButton update_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private InventoryDBDataSet inventoryDBDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private InventoryDBDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox Add_productPrice_txt;
        private Guna.UI2.WinForms.Guna2TextBox Add_productName_txt;
        private Guna.UI2.WinForms.Guna2TextBox supplierContact_txt;
        private Guna.UI2.WinForms.Guna2TextBox supplierEmail_txt;
        private Guna.UI2.WinForms.Guna2TextBox supplierName_txt;
        private Guna.UI2.WinForms.Guna2TextBox Add_productQuantity_txt;
        private Guna.UI2.WinForms.Guna2TextBox search_txt;
        private Guna.UI2.WinForms.Guna2TextBox upd_productPrice_txt;
        private Guna.UI2.WinForms.Guna2TextBox upd_productQuantity_txt;
        private Guna.UI2.WinForms.Guna2TextBox upd_productName_txt;
        private CuoreUI.Controls.cuiButton addProduct_btn;
    }
}