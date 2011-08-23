namespace SaleApp
{
    partial class f321_nhap_so_du_hang_hoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f321_nhap_so_du_hang_hoa));
            this.m_dtime_ngay_nhap = new DevExpress.XtraEditors.DateEdit();
            this.m_lbl_ngay_nhap = new System.Windows.Forms.Label();
            this.m_cbo_product = new System.Windows.Forms.ComboBox();
            this.m_lbl_product = new System.Windows.Forms.Label();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_save = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_dtime_ngay_nhap.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dtime_ngay_nhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_dtime_ngay_nhap
            // 
            this.m_dtime_ngay_nhap.EditValue = new System.DateTime(2011, 8, 22, 17, 20, 2, 0);
            this.m_dtime_ngay_nhap.Location = new System.Drawing.Point(102, 65);
            this.m_dtime_ngay_nhap.Name = "m_dtime_ngay_nhap";
            this.m_dtime_ngay_nhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dtime_ngay_nhap.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.m_dtime_ngay_nhap.Size = new System.Drawing.Size(166, 20);
            this.m_dtime_ngay_nhap.TabIndex = 0;
            this.m_dtime_ngay_nhap.ToolTip = "Ngày nhập số dư đầu";
            // 
            // m_lbl_ngay_nhap
            // 
            this.m_lbl_ngay_nhap.AutoSize = true;
            this.m_lbl_ngay_nhap.Location = new System.Drawing.Point(27, 68);
            this.m_lbl_ngay_nhap.Name = "m_lbl_ngay_nhap";
            this.m_lbl_ngay_nhap.Size = new System.Drawing.Size(59, 13);
            this.m_lbl_ngay_nhap.TabIndex = 2;
            this.m_lbl_ngay_nhap.Text = "Ngày nhập";
            // 
            // m_cbo_product
            // 
            this.m_cbo_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_product.FormattingEnabled = true;
            this.m_cbo_product.Location = new System.Drawing.Point(376, 64);
            this.m_cbo_product.Name = "m_cbo_product";
            this.m_cbo_product.Size = new System.Drawing.Size(292, 21);
            this.m_cbo_product.TabIndex = 3;
            // 
            // m_lbl_product
            // 
            this.m_lbl_product.AutoSize = true;
            this.m_lbl_product.Location = new System.Drawing.Point(313, 68);
            this.m_lbl_product.Name = "m_lbl_product";
            this.m_lbl_product.Size = new System.Drawing.Size(54, 13);
            this.m_lbl_product.TabIndex = 4;
            this.m_lbl_product.Text = "Hàng hóa";
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Blue;
            this.m_lbl_header.Location = new System.Drawing.Point(-1, 11);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(690, 32);
            this.m_lbl_header.TabIndex = 5;
            this.m_lbl_header.Text = "NHẬP SỐ DƯ ĐẦU KỲ";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.Location = new System.Drawing.Point(0, 108);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(689, 305);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 22;
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_save);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 413);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(689, 36);
            this.m_pnl_out_place_dm.TabIndex = 21;
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
            this.m_cmd_save.Location = new System.Drawing.Point(509, 4);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_save.TabIndex = 13;
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
            this.m_cmd_exit.Location = new System.Drawing.Point(597, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 12;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // f321_nhap_so_du_hang_hoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 449);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_lbl_product);
            this.Controls.Add(this.m_cbo_product);
            this.Controls.Add(this.m_lbl_ngay_nhap);
            this.Controls.Add(this.m_dtime_ngay_nhap);
            this.Name = "f321_nhap_so_du_hang_hoa";
            this.Text = "F321 - Nhập số dư đầu hàng hóa";
            ((System.ComponentModel.ISupportInitialize)(this.m_dtime_ngay_nhap.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dtime_ngay_nhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit m_dtime_ngay_nhap;
        private System.Windows.Forms.Label m_lbl_ngay_nhap;
        private System.Windows.Forms.ComboBox m_cbo_product;
        private System.Windows.Forms.Label m_lbl_product;
        private System.Windows.Forms.Label m_lbl_header;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal System.Windows.Forms.ImageList ImageList;
        internal SIS.Controls.Button.SiSButton m_cmd_save;
    }
}