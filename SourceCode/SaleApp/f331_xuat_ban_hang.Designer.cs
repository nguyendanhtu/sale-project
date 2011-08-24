namespace SaleApp
{
    partial class f331_xuat_ban_hang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f331_xuat_ban_hang));
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_customer = new System.Windows.Forms.TextBox();
            this.m_lbl_customer = new System.Windows.Forms.Label();
            this.m_cmd_add_customer = new System.Windows.Forms.Button();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_tong_so_tien = new System.Windows.Forms.TextBox();
            this.m_txt_tong_so_luong = new System.Windows.Forms.TextBox();
            this.m_txt_bill_code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_txt_tax_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m_lbl_company_info = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_dat_bill_date = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_company_info_address = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.m_lbl_company_info_name = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.m_lbl_company_phone = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.m_cbo_user = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(821, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_txt_customer
            // 
            this.m_txt_customer.Location = new System.Drawing.Point(148, 201);
            this.m_txt_customer.Name = "m_txt_customer";
            this.m_txt_customer.Size = new System.Drawing.Size(287, 20);
            this.m_txt_customer.TabIndex = 0;
            // 
            // m_lbl_customer
            // 
            this.m_lbl_customer.AutoSize = true;
            this.m_lbl_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_customer.Location = new System.Drawing.Point(25, 205);
            this.m_lbl_customer.Name = "m_lbl_customer";
            this.m_lbl_customer.Size = new System.Drawing.Size(114, 16);
            this.m_lbl_customer.TabIndex = 10;
            this.m_lbl_customer.Text = "Khách hàng           :";
            // 
            // m_cmd_add_customer
            // 
            this.m_cmd_add_customer.Location = new System.Drawing.Point(450, 199);
            this.m_cmd_add_customer.Name = "m_cmd_add_customer";
            this.m_cmd_add_customer.Size = new System.Drawing.Size(32, 22);
            this.m_cmd_add_customer.TabIndex = 1;
            this.m_cmd_add_customer.Text = "+";
            this.m_cmd_add_customer.UseVisualStyleBackColor = true;
            this.m_cmd_add_customer.Click += new System.EventHandler(this.m_cmd_add_customer_Click_1);
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.panel1);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 553);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(821, 40);
            this.m_pnl_out_place_dm.TabIndex = 10;
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.Location = new System.Drawing.Point(0, 248);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(821, 244);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.m_txt_tong_so_tien);
            this.groupBox1.Controls.Add(this.m_txt_tong_so_luong);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 492);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 61);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng số tiền :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng số lượng :";
            // 
            // m_txt_tong_so_tien
            // 
            this.m_txt_tong_so_tien.Location = new System.Drawing.Point(655, 28);
            this.m_txt_tong_so_tien.Name = "m_txt_tong_so_tien";
            this.m_txt_tong_so_tien.Size = new System.Drawing.Size(154, 20);
            this.m_txt_tong_so_tien.TabIndex = 1;
            // 
            // m_txt_tong_so_luong
            // 
            this.m_txt_tong_so_luong.AcceptsReturn = true;
            this.m_txt_tong_so_luong.Location = new System.Drawing.Point(407, 28);
            this.m_txt_tong_so_luong.Name = "m_txt_tong_so_luong";
            this.m_txt_tong_so_luong.Size = new System.Drawing.Size(106, 20);
            this.m_txt_tong_so_luong.TabIndex = 0;
            this.m_txt_tong_so_luong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // m_txt_bill_code
            // 
            this.m_txt_bill_code.Location = new System.Drawing.Point(636, 59);
            this.m_txt_bill_code.Name = "m_txt_bill_code";
            this.m_txt_bill_code.Size = new System.Drawing.Size(138, 20);
            this.m_txt_bill_code.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(547, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số hóa đơn :";
            // 
            // m_txt_tax_code
            // 
            this.m_txt_tax_code.Location = new System.Drawing.Point(450, 159);
            this.m_txt_tax_code.Name = "m_txt_tax_code";
            this.m_txt_tax_code.Size = new System.Drawing.Size(142, 20);
            this.m_txt_tax_code.TabIndex = 14;
            this.m_txt_tax_code.TextChanged += new System.EventHandler(this.m_txt_tax_code_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mã số thuế  :";
            // 
            // m_lbl_company_info
            // 
            this.m_lbl_company_info.AutoSize = true;
            this.m_lbl_company_info.Location = new System.Drawing.Point(12, 9);
            this.m_lbl_company_info.Name = "m_lbl_company_info";
            this.m_lbl_company_info.Size = new System.Drawing.Size(104, 13);
            this.m_lbl_company_info.TabIndex = 15;
            this.m_lbl_company_info.Text = "company information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(267, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ngày  :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // m_dat_bill_date
            // 
            this.m_dat_bill_date.CustomFormat = "dd/mm/yyyy";
            this.m_dat_bill_date.Location = new System.Drawing.Point(323, 59);
            this.m_dat_bill_date.Name = "m_dat_bill_date";
            this.m_dat_bill_date.Size = new System.Drawing.Size(200, 20);
            this.m_dat_bill_date.TabIndex = 17;
            this.m_dat_bill_date.ValueChanged += new System.EventHandler(this.m_dat_bill_date_ValueChanged);
            // 
            // m_lbl_company_info_address
            // 
            this.m_lbl_company_info_address.AutoSize = true;
            this.m_lbl_company_info_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_company_info_address.Location = new System.Drawing.Point(447, 117);
            this.m_lbl_company_info_address.Name = "m_lbl_company_info_address";
            this.m_lbl_company_info_address.Size = new System.Drawing.Size(236, 16);
            this.m_lbl_company_info_address.TabIndex = 53;
            this.m_lbl_company_info_address.Text = "405 Đại Cồ Việt- Hai Bà Trưng - Hà Nội";
            this.m_lbl_company_info_address.Click += new System.EventHandler(this.m_lbl_company_info_address_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 52;
            this.label10.Text = "Điện thoại               :";
            // 
            // m_lbl_company_info_name
            // 
            this.m_lbl_company_info_name.AutoSize = true;
            this.m_lbl_company_info_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_company_info_name.Location = new System.Drawing.Point(145, 117);
            this.m_lbl_company_info_name.Name = "m_lbl_company_info_name";
            this.m_lbl_company_info_name.Size = new System.Drawing.Size(115, 16);
            this.m_lbl_company_info_name.TabIndex = 51;
            this.m_lbl_company_info_name.Text = "Công ty phân phối";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Đơn vị bán hàng  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(344, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "Địa chỉ          :";
            // 
            // m_lbl_company_phone
            // 
            this.m_lbl_company_phone.AutoSize = true;
            this.m_lbl_company_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_company_phone.Location = new System.Drawing.Point(145, 159);
            this.m_lbl_company_phone.Name = "m_lbl_company_phone";
            this.m_lbl_company_phone.Size = new System.Drawing.Size(86, 16);
            this.m_lbl_company_phone.TabIndex = 56;
            this.m_lbl_company_phone.Text = "xxxxxxxxxxxxx";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(547, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 57;
            this.label9.Text = "Nhân viên  :";
            // 
            // m_cbo_user
            // 
            this.m_cbo_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_user.FormattingEnabled = true;
            this.m_cbo_user.Location = new System.Drawing.Point(636, 200);
            this.m_cbo_user.Name = "m_cbo_user";
            this.m_cbo_user.Size = new System.Drawing.Size(138, 21);
            this.m_cbo_user.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_insert);
            this.panel1.Controls.Add(this.m_cmd_update);
            this.panel1.Controls.Add(this.m_cmd_view);
            this.panel1.Controls.Add(this.m_cmd_delete);
            this.panel1.Controls.Add(this.m_cmd_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(813, 35);
            this.panel1.TabIndex = 20;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 2;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(457, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 27);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Thêm";
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
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(545, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 27);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Cập nhật";
            // 
            // m_cmd_view
            // 
            this.m_cmd_view.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_view.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_view.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_view.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_view.ImageIndex = 18;
            this.m_cmd_view.ImageList = this.ImageList;
            this.m_cmd_view.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_view.Name = "m_cmd_view";
            this.m_cmd_view.Size = new System.Drawing.Size(108, 27);
            this.m_cmd_view.TabIndex = 21;
            this.m_cmd_view.Text = "Xu&ất hóa đơn";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(633, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 27);
            this.m_cmd_delete.TabIndex = 14;
            this.m_cmd_delete.Text = "&Xoá";
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
            this.m_cmd_exit.Location = new System.Drawing.Point(721, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 27);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // f331_xuat_ban_hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(821, 593);
            this.Controls.Add(this.m_cbo_user);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.m_lbl_company_phone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.m_lbl_company_info_address);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.m_lbl_company_info_name);
            this.Controls.Add(this.m_dat_bill_date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.m_lbl_company_info);
            this.Controls.Add(this.m_txt_tax_code);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_txt_bill_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.m_cmd_add_customer);
            this.Controls.Add(this.m_txt_customer);
            this.Controls.Add(this.m_lbl_customer);
            this.Controls.Add(this.label1);
            this.Name = "f331_xuat_ban_hang";
            this.Text = "F331- Hoa don ban hang";
            this.Load += new System.EventHandler(this.f331_xuat_ban_hang_Load_1);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_customer;
        private System.Windows.Forms.Label m_lbl_customer;
        private System.Windows.Forms.Button m_cmd_add_customer;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox m_txt_tong_so_tien;
        private System.Windows.Forms.TextBox m_txt_tong_so_luong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_bill_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_txt_tax_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label m_lbl_company_info;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker m_dat_bill_date;
        private System.Windows.Forms.Label m_lbl_company_info_address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label m_lbl_company_info_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label m_lbl_company_phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox m_cbo_user;
        internal System.Windows.Forms.Panel panel1;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal System.Windows.Forms.ImageList ImageList;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_view;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
    }
}