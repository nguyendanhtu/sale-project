namespace SaleApp
{
    partial class f302_dm_product_de
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
            this.m_cbo_category = new System.Windows.Forms.ComboBox();
            this.m_lbl_categories = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_save = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_txt_description = new System.Windows.Forms.TextBox();
            this.m_lblproduct_description = new System.Windows.Forms.Label();
            this.m_lblproduct_unit = new System.Windows.Forms.Label();
            this.m_txt_product_name = new System.Windows.Forms.TextBox();
            this.m_lblproduct_name = new System.Windows.Forms.Label();
            this.m_txt_product_code = new System.Windows.Forms.TextBox();
            this.m_lblproduct_code = new System.Windows.Forms.Label();
            this.mlbl_add_product = new System.Windows.Forms.Label();
            this.m_cbo_unit = new System.Windows.Forms.ComboBox();
            this.m_txt_price = new System.Windows.Forms.TextBox();
            this.m_lbl_price = new System.Windows.Forms.Label();
            this.m_lbl_image_product = new System.Windows.Forms.Label();
            this.m_pct_image_product = new System.Windows.Forms.PictureBox();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pct_image_product)).BeginInit();
            this.SuspendLayout();
            // 
            // m_cbo_category
            // 
            this.m_cbo_category.FormattingEnabled = true;
            this.m_cbo_category.Location = new System.Drawing.Point(136, 153);
            this.m_cbo_category.Name = "m_cbo_category";
            this.m_cbo_category.Size = new System.Drawing.Size(151, 21);
            this.m_cbo_category.TabIndex = 37;
            // 
            // m_lbl_categories
            // 
            this.m_lbl_categories.AutoSize = true;
            this.m_lbl_categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_lbl_categories.Location = new System.Drawing.Point(40, 156);
            this.m_lbl_categories.Name = "m_lbl_categories";
            this.m_lbl_categories.Size = new System.Drawing.Size(83, 13);
            this.m_lbl_categories.TabIndex = 36;
            this.m_lbl_categories.Text = "Nhóm hàng hóa";
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_save);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 436);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(556, 36);
            this.m_pnl_out_place_dm.TabIndex = 35;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_save.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_save.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_save.ImageIndex = 10;
            this.m_cmd_save.Location = new System.Drawing.Point(376, 4);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_save.TabIndex = 12;
            this.m_cmd_save.Text = "&Lưu";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.Location = new System.Drawing.Point(464, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_txt_description
            // 
            this.m_txt_description.Location = new System.Drawing.Point(116, 342);
            this.m_txt_description.Multiline = true;
            this.m_txt_description.Name = "m_txt_description";
            this.m_txt_description.Size = new System.Drawing.Size(416, 73);
            this.m_txt_description.TabIndex = 34;
            // 
            // m_lblproduct_description
            // 
            this.m_lblproduct_description.AutoSize = true;
            this.m_lblproduct_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_lblproduct_description.Location = new System.Drawing.Point(45, 379);
            this.m_lblproduct_description.Name = "m_lblproduct_description";
            this.m_lblproduct_description.Size = new System.Drawing.Size(34, 13);
            this.m_lblproduct_description.TabIndex = 33;
            this.m_lblproduct_description.Text = "Mô tả";
            // 
            // m_lblproduct_unit
            // 
            this.m_lblproduct_unit.AutoSize = true;
            this.m_lblproduct_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_lblproduct_unit.Location = new System.Drawing.Point(323, 74);
            this.m_lblproduct_unit.Name = "m_lblproduct_unit";
            this.m_lblproduct_unit.Size = new System.Drawing.Size(60, 13);
            this.m_lblproduct_unit.TabIndex = 31;
            this.m_lblproduct_unit.Text = "Đơn vị tính";
            // 
            // m_txt_product_name
            // 
            this.m_txt_product_name.Location = new System.Drawing.Point(134, 112);
            this.m_txt_product_name.Name = "m_txt_product_name";
            this.m_txt_product_name.Size = new System.Drawing.Size(149, 20);
            this.m_txt_product_name.TabIndex = 28;
            // 
            // m_lblproduct_name
            // 
            this.m_lblproduct_name.AutoSize = true;
            this.m_lblproduct_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_lblproduct_name.Location = new System.Drawing.Point(41, 115);
            this.m_lblproduct_name.Name = "m_lblproduct_name";
            this.m_lblproduct_name.Size = new System.Drawing.Size(74, 13);
            this.m_lblproduct_name.TabIndex = 27;
            this.m_lblproduct_name.Text = "Tên hàng hóa";
            // 
            // m_txt_product_code
            // 
            this.m_txt_product_code.Location = new System.Drawing.Point(136, 68);
            this.m_txt_product_code.Name = "m_txt_product_code";
            this.m_txt_product_code.Size = new System.Drawing.Size(149, 20);
            this.m_txt_product_code.TabIndex = 26;
            // 
            // m_lblproduct_code
            // 
            this.m_lblproduct_code.AutoSize = true;
            this.m_lblproduct_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_lblproduct_code.Location = new System.Drawing.Point(45, 71);
            this.m_lblproduct_code.Name = "m_lblproduct_code";
            this.m_lblproduct_code.Size = new System.Drawing.Size(70, 13);
            this.m_lblproduct_code.TabIndex = 25;
            this.m_lblproduct_code.Text = "Mã hàng hóa";
            // 
            // mlbl_add_product
            // 
            this.mlbl_add_product.AutoSize = true;
            this.mlbl_add_product.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlbl_add_product.Location = new System.Drawing.Point(164, 22);
            this.mlbl_add_product.Name = "mlbl_add_product";
            this.mlbl_add_product.Size = new System.Drawing.Size(161, 25);
            this.mlbl_add_product.TabIndex = 24;
            this.mlbl_add_product.Text = "THÊM HÀNG HÓA";
            // 
            // m_cbo_unit
            // 
            this.m_cbo_unit.FormattingEnabled = true;
            this.m_cbo_unit.Location = new System.Drawing.Point(394, 70);
            this.m_cbo_unit.Name = "m_cbo_unit";
            this.m_cbo_unit.Size = new System.Drawing.Size(88, 21);
            this.m_cbo_unit.TabIndex = 38;
            // 
            // m_txt_price
            // 
            this.m_txt_price.Location = new System.Drawing.Point(136, 204);
            this.m_txt_price.Name = "m_txt_price";
            this.m_txt_price.Size = new System.Drawing.Size(149, 20);
            this.m_txt_price.TabIndex = 42;
            // 
            // m_lbl_price
            // 
            this.m_lbl_price.AutoSize = true;
            this.m_lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_lbl_price.Location = new System.Drawing.Point(49, 207);
            this.m_lbl_price.Name = "m_lbl_price";
            this.m_lbl_price.Size = new System.Drawing.Size(71, 13);
            this.m_lbl_price.TabIndex = 41;
            this.m_lbl_price.Text = "Giá hàng hóa";
            // 
            // m_lbl_image_product
            // 
            this.m_lbl_image_product.AutoSize = true;
            this.m_lbl_image_product.Location = new System.Drawing.Point(407, 286);
            this.m_lbl_image_product.Name = "m_lbl_image_product";
            this.m_lbl_image_product.Size = new System.Drawing.Size(75, 13);
            this.m_lbl_image_product.TabIndex = 43;
            this.m_lbl_image_product.Text = "Ảnh sản phẩm";
            // 
            // m_pct_image_product
            // 
            this.m_pct_image_product.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_pct_image_product.Location = new System.Drawing.Point(365, 115);
            this.m_pct_image_product.Name = "m_pct_image_product";
            this.m_pct_image_product.Size = new System.Drawing.Size(158, 147);
            this.m_pct_image_product.TabIndex = 44;
            this.m_pct_image_product.TabStop = false;
            // 
            // f302_dm_product_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 472);
            this.Controls.Add(this.m_pct_image_product);
            this.Controls.Add(this.m_lbl_image_product);
            this.Controls.Add(this.m_txt_price);
            this.Controls.Add(this.m_lbl_price);
            this.Controls.Add(this.m_cbo_unit);
            this.Controls.Add(this.m_cbo_category);
            this.Controls.Add(this.m_lbl_categories);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.m_txt_description);
            this.Controls.Add(this.m_lblproduct_description);
            this.Controls.Add(this.m_lblproduct_unit);
            this.Controls.Add(this.m_txt_product_name);
            this.Controls.Add(this.m_lblproduct_name);
            this.Controls.Add(this.m_txt_product_code);
            this.Controls.Add(this.m_lblproduct_code);
            this.Controls.Add(this.mlbl_add_product);
            this.Name = "f302_dm_product_de";
            this.Text = "f302 Thêm hàng hóa";
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_pct_image_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox m_cbo_category;
        private System.Windows.Forms.Label m_lbl_categories;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_save;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private System.Windows.Forms.TextBox m_txt_description;
        private System.Windows.Forms.Label m_lblproduct_description;
        private System.Windows.Forms.Label m_lblproduct_unit;
        private System.Windows.Forms.TextBox m_txt_product_name;
        private System.Windows.Forms.Label m_lblproduct_name;
        private System.Windows.Forms.TextBox m_txt_product_code;
        private System.Windows.Forms.Label m_lblproduct_code;
        private System.Windows.Forms.Label mlbl_add_product;
        private System.Windows.Forms.ComboBox m_cbo_unit;
        private System.Windows.Forms.TextBox m_txt_price;
        private System.Windows.Forms.Label m_lbl_price;
        private System.Windows.Forms.Label m_lbl_image_product;
        private System.Windows.Forms.PictureBox m_pct_image_product;
    }
}