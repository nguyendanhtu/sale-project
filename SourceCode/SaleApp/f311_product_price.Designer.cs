namespace SaleApp
{
    partial class f311_product_price
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f311_product_price));
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.mlbl_add_category = new System.Windows.Forms.Label();
            this.m_cbo_product_name = new System.Windows.Forms.ComboBox();
            this.m_dat_price_date = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_product_name = new System.Windows.Forms.Label();
            this.m_lbl_price_date = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_save = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_cbo_catalogy = new System.Windows.Forms.ComboBox();
            this.m_lbl_catalogy = new System.Windows.Forms.Label();
            this.m_lbl_price = new System.Windows.Forms.Label();
            this.m_txt_price = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Location = new System.Drawing.Point(12, 176);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(778, 206);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 21;
            // 
            // mlbl_add_category
            // 
            this.mlbl_add_category.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlbl_add_category.Location = new System.Drawing.Point(0, 9);
            this.mlbl_add_category.Name = "mlbl_add_category";
            this.mlbl_add_category.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.mlbl_add_category.Size = new System.Drawing.Size(798, 39);
            this.mlbl_add_category.TabIndex = 22;
            this.mlbl_add_category.Text = "CẬP NHẬT GIÁ SẢN PHẨM";
            this.mlbl_add_category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_cbo_product_name
            // 
            this.m_cbo_product_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_cbo_product_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.m_cbo_product_name.FormattingEnabled = true;
            this.m_cbo_product_name.Location = new System.Drawing.Point(162, 92);
            this.m_cbo_product_name.Name = "m_cbo_product_name";
            this.m_cbo_product_name.Size = new System.Drawing.Size(488, 21);
            this.m_cbo_product_name.TabIndex = 23;
            // 
            // m_dat_price_date
            // 
            this.m_dat_price_date.CustomFormat = "dd/MM/yyyy";
            this.m_dat_price_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_price_date.Location = new System.Drawing.Point(458, 129);
            this.m_dat_price_date.Name = "m_dat_price_date";
            this.m_dat_price_date.Size = new System.Drawing.Size(192, 20);
            this.m_dat_price_date.TabIndex = 24;
            // 
            // m_lbl_product_name
            // 
            this.m_lbl_product_name.AutoSize = true;
            this.m_lbl_product_name.Location = new System.Drawing.Point(46, 95);
            this.m_lbl_product_name.Name = "m_lbl_product_name";
            this.m_lbl_product_name.Size = new System.Drawing.Size(74, 13);
            this.m_lbl_product_name.TabIndex = 25;
            this.m_lbl_product_name.Text = "Tên hàng hóa";
            // 
            // m_lbl_price_date
            // 
            this.m_lbl_price_date.AutoSize = true;
            this.m_lbl_price_date.Location = new System.Drawing.Point(368, 133);
            this.m_lbl_price_date.Name = "m_lbl_price_date";
            this.m_lbl_price_date.Size = new System.Drawing.Size(77, 13);
            this.m_lbl_price_date.TabIndex = 26;
            this.m_lbl_price_date.Text = "Ngày cập nhật";
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_save);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 427);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(802, 36);
            this.m_pnl_out_place_dm.TabIndex = 27;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_save.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_save.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_save.ImageIndex = 10;
            this.m_cmd_save.ImageList = this.ImageList;
            this.m_cmd_save.Location = new System.Drawing.Point(622, 4);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_save.TabIndex = 12;
            this.m_cmd_save.Text = "&Lưu";
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(710, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_cbo_catalogy
            // 
            this.m_cbo_catalogy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_cbo_catalogy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.m_cbo_catalogy.FormattingEnabled = true;
            this.m_cbo_catalogy.Location = new System.Drawing.Point(162, 57);
            this.m_cbo_catalogy.Name = "m_cbo_catalogy";
            this.m_cbo_catalogy.Size = new System.Drawing.Size(488, 21);
            this.m_cbo_catalogy.TabIndex = 23;
            // 
            // m_lbl_catalogy
            // 
            this.m_lbl_catalogy.AutoSize = true;
            this.m_lbl_catalogy.Location = new System.Drawing.Point(46, 57);
            this.m_lbl_catalogy.Name = "m_lbl_catalogy";
            this.m_lbl_catalogy.Size = new System.Drawing.Size(65, 13);
            this.m_lbl_catalogy.TabIndex = 25;
            this.m_lbl_catalogy.Text = "Nhóm hàng ";
            // 
            // m_lbl_price
            // 
            this.m_lbl_price.AutoSize = true;
            this.m_lbl_price.Location = new System.Drawing.Point(46, 135);
            this.m_lbl_price.Name = "m_lbl_price";
            this.m_lbl_price.Size = new System.Drawing.Size(68, 13);
            this.m_lbl_price.TabIndex = 28;
            this.m_lbl_price.Text = "Giá cập nhật";
            // 
            // m_txt_price
            // 
            this.m_txt_price.Location = new System.Drawing.Point(162, 129);
            this.m_txt_price.Name = "m_txt_price";
            this.m_txt_price.Size = new System.Drawing.Size(195, 20);
            this.m_txt_price.TabIndex = 29;
            this.m_txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // f311_product_price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 463);
            this.Controls.Add(this.m_txt_price);
            this.Controls.Add(this.m_lbl_price);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.m_lbl_price_date);
            this.Controls.Add(this.m_lbl_catalogy);
            this.Controls.Add(this.m_lbl_product_name);
            this.Controls.Add(this.m_dat_price_date);
            this.Controls.Add(this.m_cbo_catalogy);
            this.Controls.Add(this.m_cbo_product_name);
            this.Controls.Add(this.mlbl_add_category);
            this.Controls.Add(this.m_fg);
            this.Name = "f311_product_price";
            this.Text = "F311-Cập nhật giá sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        private System.Windows.Forms.Label mlbl_add_category;
        private System.Windows.Forms.ComboBox m_cbo_product_name;
        private System.Windows.Forms.DateTimePicker m_dat_price_date;
        private System.Windows.Forms.Label m_lbl_product_name;
        private System.Windows.Forms.Label m_lbl_price_date;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_save;
        internal System.Windows.Forms.ImageList ImageList;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private System.Windows.Forms.ComboBox m_cbo_catalogy;
        private System.Windows.Forms.Label m_lbl_catalogy;
        private System.Windows.Forms.Label m_lbl_price;
        private System.Windows.Forms.TextBox m_txt_price;
    }
}