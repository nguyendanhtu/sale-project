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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f321_nhap_so_du_hang_hoa));
            this.m_dtime_ngay_nhap = new DevExpress.XtraEditors.DateEdit();
            this.m_lbl_ngay_nhap = new System.Windows.Forms.Label();
            this.m_cbo_product = new System.Windows.Forms.ComboBox();
            this.m_lbl_product = new System.Windows.Forms.Label();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.m_dtime_ngay_nhap.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dtime_ngay_nhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.SuspendLayout();
            // 
            // m_dtime_ngay_nhap
            // 
            this.m_dtime_ngay_nhap.EditValue = new System.DateTime(2011, 8, 22, 17, 20, 2, 0);
            this.m_dtime_ngay_nhap.Location = new System.Drawing.Point(93, 63);
            this.m_dtime_ngay_nhap.Name = "m_dtime_ngay_nhap";
            this.m_dtime_ngay_nhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dtime_ngay_nhap.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.m_dtime_ngay_nhap.Size = new System.Drawing.Size(188, 20);
            this.m_dtime_ngay_nhap.TabIndex = 0;
            this.m_dtime_ngay_nhap.ToolTip = "Ngày nhập số dư đầu";
            // 
            // m_lbl_ngay_nhap
            // 
            this.m_lbl_ngay_nhap.AutoSize = true;
            this.m_lbl_ngay_nhap.Location = new System.Drawing.Point(18, 66);
            this.m_lbl_ngay_nhap.Name = "m_lbl_ngay_nhap";
            this.m_lbl_ngay_nhap.Size = new System.Drawing.Size(59, 13);
            this.m_lbl_ngay_nhap.TabIndex = 2;
            this.m_lbl_ngay_nhap.Text = "Ngày nhập";
            // 
            // m_cbo_product
            // 
            this.m_cbo_product.FormattingEnabled = true;
            this.m_cbo_product.Location = new System.Drawing.Point(377, 58);
            this.m_cbo_product.Name = "m_cbo_product";
            this.m_cbo_product.Size = new System.Drawing.Size(240, 21);
            this.m_cbo_product.TabIndex = 3;
            // 
            // m_lbl_product
            // 
            this.m_lbl_product.AutoSize = true;
            this.m_lbl_product.Location = new System.Drawing.Point(323, 66);
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
            this.m_lbl_header.Size = new System.Drawing.Size(650, 32);
            this.m_lbl_header.TabIndex = 5;
            this.m_lbl_header.Text = "NHẬP SỐ DƯ ĐẦU KỲ";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.Location = new System.Drawing.Point(0, 112);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(675, 299);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 21;
            // 
            // f321_nhap_so_du_hang_hoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 411);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_lbl_product);
            this.Controls.Add(this.m_cbo_product);
            this.Controls.Add(this.m_lbl_ngay_nhap);
            this.Controls.Add(this.m_dtime_ngay_nhap);
            this.Name = "f321_nhap_so_du_hang_hoa";
            this.Text = "F321 - Nhập số dư đầu hàng hóa";
            this.Load += new System.EventHandler(this.f321_nhap_so_du_hang_hoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_dtime_ngay_nhap.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dtime_ngay_nhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
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
    }
}