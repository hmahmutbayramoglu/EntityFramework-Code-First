namespace EntityFramework_Code_First
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_CustomerID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_Add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Update = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_GetCustomer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_OrderAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ContactName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CompanyName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Country = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_City = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_GetCustomerİD = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_OrderİD = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.grbx_Customer = new System.Windows.Forms.GroupBox();
            this.grbx_Order = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ShipCity = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ShipCountry = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbx_Customer.SuspendLayout();
            this.grbx_Order.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(669, 4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(323, 442);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_CustomerID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_CustomerID.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_CustomerID.BorderThickness = 1;
            this.txt_CustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CustomerID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_CustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_CustomerID.isPassword = false;
            this.txt_CustomerID.Location = new System.Drawing.Point(21, 46);
            this.txt_CustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(208, 34);
            this.txt_CustomerID.TabIndex = 0;
            this.txt_CustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Add
            // 
            this.btn_Add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add.BorderRadius = 0;
            this.btn_Add.ButtonText = "Add";
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Add.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Add.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Add.Iconimage")));
            this.btn_Add.Iconimage_right = null;
            this.btn_Add.Iconimage_right_Selected = null;
            this.btn_Add.Iconimage_Selected = null;
            this.btn_Add.IconMarginLeft = 0;
            this.btn_Add.IconMarginRight = 0;
            this.btn_Add.IconRightVisible = true;
            this.btn_Add.IconRightZoom = 0D;
            this.btn_Add.IconVisible = true;
            this.btn_Add.IconZoom = 90D;
            this.btn_Add.IsTab = false;
            this.btn_Add.Location = new System.Drawing.Point(347, 122);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Add.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Add.selected = false;
            this.btn_Add.Size = new System.Drawing.Size(160, 36);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Textcolor = System.Drawing.Color.White;
            this.btn_Add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Update.BorderRadius = 0;
            this.btn_Update.ButtonText = "Update";
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Update.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Update.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Update.Iconimage")));
            this.btn_Update.Iconimage_right = null;
            this.btn_Update.Iconimage_right_Selected = null;
            this.btn_Update.Iconimage_Selected = null;
            this.btn_Update.IconMarginLeft = 0;
            this.btn_Update.IconMarginRight = 0;
            this.btn_Update.IconRightVisible = true;
            this.btn_Update.IconRightZoom = 0D;
            this.btn_Update.IconVisible = true;
            this.btn_Update.IconZoom = 90D;
            this.btn_Update.IsTab = false;
            this.btn_Update.Location = new System.Drawing.Point(347, 170);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Update.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Update.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Update.selected = false;
            this.btn_Update.Size = new System.Drawing.Size(160, 36);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Update";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Textcolor = System.Drawing.Color.White;
            this.btn_Update.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Delete.BorderRadius = 0;
            this.btn_Delete.ButtonText = "Delete";
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Delete.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Delete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Iconimage")));
            this.btn_Delete.Iconimage_right = null;
            this.btn_Delete.Iconimage_right_Selected = null;
            this.btn_Delete.Iconimage_Selected = null;
            this.btn_Delete.IconMarginLeft = 0;
            this.btn_Delete.IconMarginRight = 0;
            this.btn_Delete.IconRightVisible = true;
            this.btn_Delete.IconRightZoom = 0D;
            this.btn_Delete.IconVisible = true;
            this.btn_Delete.IconZoom = 90D;
            this.btn_Delete.IsTab = false;
            this.btn_Delete.Location = new System.Drawing.Point(347, 212);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Delete.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Delete.selected = false;
            this.btn_Delete.Size = new System.Drawing.Size(160, 36);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Textcolor = System.Drawing.Color.White;
            this.btn_Delete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_GetCustomer
            // 
            this.btn_GetCustomer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_GetCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_GetCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_GetCustomer.BorderRadius = 0;
            this.btn_GetCustomer.ButtonText = "Get Customer";
            this.btn_GetCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GetCustomer.DisabledColor = System.Drawing.Color.Gray;
            this.btn_GetCustomer.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_GetCustomer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_GetCustomer.Iconimage")));
            this.btn_GetCustomer.Iconimage_right = null;
            this.btn_GetCustomer.Iconimage_right_Selected = null;
            this.btn_GetCustomer.Iconimage_Selected = null;
            this.btn_GetCustomer.IconMarginLeft = 0;
            this.btn_GetCustomer.IconMarginRight = 0;
            this.btn_GetCustomer.IconRightVisible = true;
            this.btn_GetCustomer.IconRightZoom = 0D;
            this.btn_GetCustomer.IconVisible = true;
            this.btn_GetCustomer.IconZoom = 90D;
            this.btn_GetCustomer.IsTab = false;
            this.btn_GetCustomer.Location = new System.Drawing.Point(429, 276);
            this.btn_GetCustomer.Name = "btn_GetCustomer";
            this.btn_GetCustomer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_GetCustomer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_GetCustomer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_GetCustomer.selected = false;
            this.btn_GetCustomer.Size = new System.Drawing.Size(160, 36);
            this.btn_GetCustomer.TabIndex = 10;
            this.btn_GetCustomer.Text = "Get Customer";
            this.btn_GetCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GetCustomer.Textcolor = System.Drawing.Color.White;
            this.btn_GetCustomer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetCustomer.Click += new System.EventHandler(this.btn_GetCustomer_Click);
            // 
            // btn_OrderAdd
            // 
            this.btn_OrderAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_OrderAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_OrderAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_OrderAdd.BorderRadius = 0;
            this.btn_OrderAdd.ButtonText = "Order Add";
            this.btn_OrderAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OrderAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btn_OrderAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_OrderAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_OrderAdd.Iconimage")));
            this.btn_OrderAdd.Iconimage_right = null;
            this.btn_OrderAdd.Iconimage_right_Selected = null;
            this.btn_OrderAdd.Iconimage_Selected = null;
            this.btn_OrderAdd.IconMarginLeft = 0;
            this.btn_OrderAdd.IconMarginRight = 0;
            this.btn_OrderAdd.IconRightVisible = true;
            this.btn_OrderAdd.IconRightZoom = 0D;
            this.btn_OrderAdd.IconVisible = true;
            this.btn_OrderAdd.IconZoom = 90D;
            this.btn_OrderAdd.IsTab = false;
            this.btn_OrderAdd.Location = new System.Drawing.Point(243, 123);
            this.btn_OrderAdd.Name = "btn_OrderAdd";
            this.btn_OrderAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_OrderAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_OrderAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_OrderAdd.selected = false;
            this.btn_OrderAdd.Size = new System.Drawing.Size(166, 34);
            this.btn_OrderAdd.TabIndex = 11;
            this.btn_OrderAdd.Text = "Order Add";
            this.btn_OrderAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OrderAdd.Textcolor = System.Drawing.Color.White;
            this.btn_OrderAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrderAdd.Click += new System.EventHandler(this.btn_OrderAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "CustomerID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "ContactName";
            // 
            // txt_ContactName
            // 
            this.txt_ContactName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_ContactName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ContactName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_ContactName.BorderThickness = 1;
            this.txt_ContactName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ContactName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ContactName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ContactName.isPassword = false;
            this.txt_ContactName.Location = new System.Drawing.Point(21, 104);
            this.txt_ContactName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ContactName.Name = "txt_ContactName";
            this.txt_ContactName.Size = new System.Drawing.Size(208, 34);
            this.txt_ContactName.TabIndex = 1;
            this.txt_ContactName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "CompanyName";
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_CompanyName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_CompanyName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_CompanyName.BorderThickness = 1;
            this.txt_CompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CompanyName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_CompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_CompanyName.isPassword = false;
            this.txt_CompanyName.Location = new System.Drawing.Point(21, 162);
            this.txt_CompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(208, 34);
            this.txt_CompanyName.TabIndex = 2;
            this.txt_CompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Order İD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Country";
            // 
            // txt_Country
            // 
            this.txt_Country.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_Country.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Country.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_Country.BorderThickness = 1;
            this.txt_Country.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Country.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Country.isPassword = false;
            this.txt_Country.Location = new System.Drawing.Point(21, 278);
            this.txt_Country.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(208, 34);
            this.txt_Country.TabIndex = 4;
            this.txt_Country.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(18, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "City";
            // 
            // txt_City
            // 
            this.txt_City.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_City.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_City.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_City.BorderThickness = 1;
            this.txt_City.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_City.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_City.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_City.isPassword = false;
            this.txt_City.Location = new System.Drawing.Point(21, 220);
            this.txt_City.Margin = new System.Windows.Forms.Padding(4);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(208, 34);
            this.txt_City.TabIndex = 3;
            this.txt_City.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Search
            // 
            this.txt_Search.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_Search.BorderColorIdle = System.Drawing.Color.BlueViolet;
            this.txt_Search.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_Search.BorderThickness = 1;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Search.isPassword = false;
            this.txt_Search.Location = new System.Drawing.Point(325, 66);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(225, 34);
            this.txt_Search.TabIndex = 6;
            this.txt_Search.Text = "Search";
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Search.OnValueChanged += new System.EventHandler(this.txt_Search_OnValueChanged);
            this.txt_Search.Enter += new System.EventHandler(this.txt_Search_Enter);
            this.txt_Search.Leave += new System.EventHandler(this.txt_Search_Leave);
            // 
            // txt_GetCustomerİD
            // 
            this.txt_GetCustomerİD.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_GetCustomerİD.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_GetCustomerİD.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_GetCustomerİD.BorderThickness = 1;
            this.txt_GetCustomerİD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_GetCustomerİD.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_GetCustomerİD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_GetCustomerİD.isPassword = false;
            this.txt_GetCustomerİD.Location = new System.Drawing.Point(263, 278);
            this.txt_GetCustomerİD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GetCustomerİD.Name = "txt_GetCustomerİD";
            this.txt_GetCustomerİD.Size = new System.Drawing.Size(159, 31);
            this.txt_GetCustomerİD.TabIndex = 24;
            this.txt_GetCustomerİD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_OrderİD
            // 
            this.txt_OrderİD.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_OrderİD.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_OrderİD.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_OrderİD.BorderThickness = 1;
            this.txt_OrderİD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_OrderİD.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_OrderİD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_OrderİD.isPassword = false;
            this.txt_OrderİD.Location = new System.Drawing.Point(9, 53);
            this.txt_OrderİD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_OrderİD.Name = "txt_OrderİD";
            this.txt_OrderİD.Size = new System.Drawing.Size(208, 34);
            this.txt_OrderİD.TabIndex = 5;
            this.txt_OrderİD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // grbx_Customer
            // 
            this.grbx_Customer.Controls.Add(this.label1);
            this.grbx_Customer.Controls.Add(this.txt_CustomerID);
            this.grbx_Customer.Controls.Add(this.txt_GetCustomerİD);
            this.grbx_Customer.Controls.Add(this.txt_ContactName);
            this.grbx_Customer.Controls.Add(this.txt_Search);
            this.grbx_Customer.Controls.Add(this.label2);
            this.grbx_Customer.Controls.Add(this.btn_GetCustomer);
            this.grbx_Customer.Controls.Add(this.label5);
            this.grbx_Customer.Controls.Add(this.btn_Delete);
            this.grbx_Customer.Controls.Add(this.txt_CompanyName);
            this.grbx_Customer.Controls.Add(this.btn_Update);
            this.grbx_Customer.Controls.Add(this.txt_Country);
            this.grbx_Customer.Controls.Add(this.btn_Add);
            this.grbx_Customer.Controls.Add(this.label3);
            this.grbx_Customer.Controls.Add(this.label6);
            this.grbx_Customer.Controls.Add(this.txt_City);
            this.grbx_Customer.Location = new System.Drawing.Point(12, 12);
            this.grbx_Customer.Name = "grbx_Customer";
            this.grbx_Customer.Size = new System.Drawing.Size(611, 339);
            this.grbx_Customer.TabIndex = 25;
            this.grbx_Customer.TabStop = false;
            this.grbx_Customer.Text = "Customer";
            // 
            // grbx_Order
            // 
            this.grbx_Order.Controls.Add(this.label8);
            this.grbx_Order.Controls.Add(this.txt_ShipCountry);
            this.grbx_Order.Controls.Add(this.label7);
            this.grbx_Order.Controls.Add(this.txt_ShipCity);
            this.grbx_Order.Controls.Add(this.label4);
            this.grbx_Order.Controls.Add(this.txt_OrderİD);
            this.grbx_Order.Controls.Add(this.btn_OrderAdd);
            this.grbx_Order.Location = new System.Drawing.Point(12, 357);
            this.grbx_Order.Name = "grbx_Order";
            this.grbx_Order.Size = new System.Drawing.Size(611, 186);
            this.grbx_Order.TabIndex = 26;
            this.grbx_Order.TabStop = false;
            this.grbx_Order.Text = "Order";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "ShipCity";
            // 
            // txt_ShipCity
            // 
            this.txt_ShipCity.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_ShipCity.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ShipCity.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_ShipCity.BorderThickness = 1;
            this.txt_ShipCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ShipCity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ShipCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ShipCity.isPassword = false;
            this.txt_ShipCity.Location = new System.Drawing.Point(9, 123);
            this.txt_ShipCity.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ShipCity.Name = "txt_ShipCity";
            this.txt_ShipCity.Size = new System.Drawing.Size(208, 34);
            this.txt_ShipCity.TabIndex = 24;
            this.txt_ShipCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(222, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "ShipCountry";
            // 
            // txt_ShipCountry
            // 
            this.txt_ShipCountry.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_ShipCountry.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ShipCountry.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_ShipCountry.BorderThickness = 1;
            this.txt_ShipCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ShipCountry.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ShipCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ShipCountry.isPassword = false;
            this.txt_ShipCountry.Location = new System.Drawing.Point(225, 53);
            this.txt_ShipCountry.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ShipCountry.Name = "txt_ShipCountry";
            this.txt_ShipCountry.Size = new System.Drawing.Size(208, 34);
            this.txt_ShipCountry.TabIndex = 26;
            this.txt_ShipCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 555);
            this.Controls.Add(this.grbx_Order);
            this.Controls.Add(this.grbx_Customer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbx_Customer.ResumeLayout(false);
            this.grbx_Customer.PerformLayout();
            this.grbx_Order.ResumeLayout(false);
            this.grbx_Order.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_CustomerID;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Add;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Update;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Delete;
        private Bunifu.Framework.UI.BunifuFlatButton btn_GetCustomer;
        private Bunifu.Framework.UI.BunifuFlatButton btn_OrderAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ContactName;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_CompanyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Country;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_City;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Search;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_GetCustomerİD;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_OrderİD;
        private System.Windows.Forms.GroupBox grbx_Customer;
        private System.Windows.Forms.GroupBox grbx_Order;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ShipCountry;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ShipCity;
    }
}

