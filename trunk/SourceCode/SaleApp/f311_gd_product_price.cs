///************************************************
/// Generated by: linhdh
/// Date: 28/08/2011 04:42:59
/// Goal: Create Form for V_GD_PRODUCT_PRICE
///************************************************


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;

using SaleUS;
using SaleDS;
using Sale.CDBNames;

using C1.Win.C1FlexGrid;

namespace SaleApp
{



	public class f311_gd_product_price : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private GroupBox groupBox1;
        private Label m_lbl_header;
        private Label m_lbl_applied_date;
        private ComboBox m_cbo_product;
        private Label m_lbl_product;
        private Label m_lbl_price;
        private TextBox m_txt_price;
        private DateTimePicker m_dat_applied_date;
        private Label m_lbl_unit;
        private TextBox m_txt_unit;
		private System.ComponentModel.IContainer components;

		public f311_gd_product_price()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			format_controls();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f311_gd_product_price));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_dat_applied_date = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_price = new System.Windows.Forms.Label();
            this.m_txt_price = new System.Windows.Forms.TextBox();
            this.m_lbl_applied_date = new System.Windows.Forms.Label();
            this.m_cbo_product = new System.Windows.Forms.ComboBox();
            this.m_lbl_product = new System.Windows.Forms.Label();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_lbl_unit = new System.Windows.Forms.Label();
            this.m_txt_unit = new System.Windows.Forms.TextBox();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 432);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(757, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 10;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(577, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 0;
            this.m_cmd_insert.Text = "&Lưu";
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
            this.m_cmd_exit.Location = new System.Drawing.Point(665, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 1;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 184);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(757, 248);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_lbl_unit);
            this.groupBox1.Controls.Add(this.m_txt_unit);
            this.groupBox1.Controls.Add(this.m_dat_applied_date);
            this.groupBox1.Controls.Add(this.m_lbl_price);
            this.groupBox1.Controls.Add(this.m_txt_price);
            this.groupBox1.Controls.Add(this.m_lbl_applied_date);
            this.groupBox1.Controls.Add(this.m_cbo_product);
            this.groupBox1.Controls.Add(this.m_lbl_product);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 152);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cập nhật";
            // 
            // m_dat_applied_date
            // 
            this.m_dat_applied_date.CustomFormat = "dd/MM/yyyy";
            this.m_dat_applied_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_applied_date.Location = new System.Drawing.Point(119, 115);
            this.m_dat_applied_date.Name = "m_dat_applied_date";
            this.m_dat_applied_date.Size = new System.Drawing.Size(184, 20);
            this.m_dat_applied_date.TabIndex = 7;
            // 
            // m_lbl_price
            // 
            this.m_lbl_price.AutoSize = true;
            this.m_lbl_price.Location = new System.Drawing.Point(45, 76);
            this.m_lbl_price.Name = "m_lbl_price";
            this.m_lbl_price.Size = new System.Drawing.Size(44, 13);
            this.m_lbl_price.TabIndex = 2;
            this.m_lbl_price.Text = "Giá bán";
            // 
            // m_txt_price
            // 
            this.m_txt_price.Location = new System.Drawing.Point(119, 73);
            this.m_txt_price.Name = "m_txt_price";
            this.m_txt_price.Size = new System.Drawing.Size(223, 20);
            this.m_txt_price.TabIndex = 3;
            // 
            // m_lbl_applied_date
            // 
            this.m_lbl_applied_date.AutoSize = true;
            this.m_lbl_applied_date.Location = new System.Drawing.Point(17, 118);
            this.m_lbl_applied_date.Name = "m_lbl_applied_date";
            this.m_lbl_applied_date.Size = new System.Drawing.Size(59, 13);
            this.m_lbl_applied_date.TabIndex = 6;
            this.m_lbl_applied_date.Text = "Áp dụng từ";
            // 
            // m_cbo_product
            // 
            this.m_cbo_product.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_cbo_product.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.m_cbo_product.FormattingEnabled = true;
            this.m_cbo_product.Location = new System.Drawing.Point(119, 33);
            this.m_cbo_product.Name = "m_cbo_product";
            this.m_cbo_product.Size = new System.Drawing.Size(545, 21);
            this.m_cbo_product.TabIndex = 1;
            // 
            // m_lbl_product
            // 
            this.m_lbl_product.AutoSize = true;
            this.m_lbl_product.Location = new System.Drawing.Point(45, 36);
            this.m_lbl_product.Name = "m_lbl_product";
            this.m_lbl_product.Size = new System.Drawing.Size(55, 13);
            this.m_lbl_product.TabIndex = 0;
            this.m_lbl_product.Text = "Sản phẩm";
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.m_lbl_header.Size = new System.Drawing.Size(757, 32);
            this.m_lbl_header.TabIndex = 22;
            this.m_lbl_header.Text = "CẬP NHẬT GIÁ BÁN SẢN PHẨM";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_lbl_unit
            // 
            this.m_lbl_unit.AutoSize = true;
            this.m_lbl_unit.Location = new System.Drawing.Point(399, 76);
            this.m_lbl_unit.Name = "m_lbl_unit";
            this.m_lbl_unit.Size = new System.Drawing.Size(38, 13);
            this.m_lbl_unit.TabIndex = 4;
            this.m_lbl_unit.Text = "Đơn vị";
            // 
            // m_txt_unit
            // 
            this.m_txt_unit.Enabled = false;
            this.m_txt_unit.Location = new System.Drawing.Point(473, 73);
            this.m_txt_unit.Name = "m_txt_unit";
            this.m_txt_unit.Size = new System.Drawing.Size(191, 20);
            this.m_txt_unit.TabIndex = 5;
            this.m_txt_unit.Text = "CAI";
            // 
            // f311_gd_product_price
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(757, 468);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f311_gd_product_price";
            this.Text = "f311_gd_product_price";
            this.Load += new System.EventHandler(this.f311_gd_product_price_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
		#endregion

		#region Data Structure
		private enum e_col_Number{
			APPLY_DATE = 3            ,UNIT_CODE = 4            ,PRODUCT_NAME = 1            ,PRICE = 2
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_GD_PRODUCT_PRICE m_ds = new DS_V_GD_PRODUCT_PRICE();
		US_V_GD_PRODUCT_PRICE m_us = new US_V_GD_PRODUCT_PRICE();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this);
			CControlFormat.setC1FlexFormat(m_fg);
			CGridUtils.AddSave_Excel_Handlers(m_fg);
			CGridUtils.AddSearch_Handlers(m_fg);
			set_define_events();
			this.KeyPreview = true;
            m_lbl_header.Font = new Font("Arial", 16);
            m_lbl_header.ForeColor = Color.Blue;
            CControlFormat.setLabelStyle(m_lbl_applied_date, CControlFormat.LabelStyle.Title_Info);
            CControlFormat.setLabelStyle(m_lbl_price, CControlFormat.LabelStyle.Title_Info);
            CControlFormat.setLabelStyle(m_lbl_product, CControlFormat.LabelStyle.Title_Info);
            CControlFormat.setLabelStyle(m_lbl_unit, CControlFormat.LabelStyle.Title_Info);
		}
        private void load_data_2_product_cbo()
        {
            US_DM_PRODUCT v_us_product_price = new US_DM_PRODUCT();
            DS_DM_PRODUCT v_ds_product_price = new DS_DM_PRODUCT();
            v_us_product_price.FillDataset(v_ds_product_price);

            m_cbo_product.DisplayMember = DM_PRODUCT.PRODUCT_NAME;
            m_cbo_product.ValueMember = DM_PRODUCT.ID;
            m_cbo_product.DataSource = v_ds_product_price.DM_PRODUCT;
        }
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
            load_data_2_product_cbo();
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_GD_PRODUCT_PRICE.APPLY_DATE, e_col_Number.APPLY_DATE);			v_htb.Add(V_GD_PRODUCT_PRICE.UNIT_CODE, e_col_Number.UNIT_CODE);			v_htb.Add(V_GD_PRODUCT_PRICE.PRODUCT_NAME, e_col_Number.PRODUCT_NAME);			v_htb.Add(V_GD_PRODUCT_PRICE.PRICE, e_col_Number.PRICE);									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_GD_PRODUCT_PRICE.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_GD_PRODUCT_PRICE();			
			m_us.FillDataset(m_ds);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
			m_fg.Redraw = true;
		}
		private void grid2us_object(US_V_GD_PRODUCT_PRICE i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}
        private bool check_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_price, DataType.NumberType, allowNull.NO, true))
                return false;
            return true;
        }
        private void save_data()
        {
            if (!check_data_is_ok()) return;
            form_2_us_object(m_us);
            m_us.Insert_to_product_price(m_us.dcPRODUCT_ID, m_us.datAPPLY_DATE, m_us.dcPRICE, m_us.dcUNIT_ID);
            BaseMessages.MsgBox_Infor(10);
        }
        private void form_2_us_object(US_V_GD_PRODUCT_PRICE op_us_gd_product_price)
        {
            op_us_gd_product_price.dcPRODUCT_ID = decimal.Parse(m_cbo_product.SelectedValue.ToString());
            op_us_gd_product_price.dcPRICE = decimal.Parse(m_txt_price.Text);
            op_us_gd_product_price.datAPPLY_DATE = m_dat_applied_date.Value.Date;
            op_us_gd_product_price.dcUNIT_ID = 1;
        }
		private void us_object2grid(US_V_GD_PRODUCT_PRICE i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_gd_product_price(){
            save_data();
			load_data_2_grid();
		}

		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_txt_price.Leave += new EventHandler(m_txt_price_Leave);
		}

		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f311_gd_product_price_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		
		}

		private void m_cmd_exit_Click(object sender, EventArgs e) {
			try{
				this.Close();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_insert_Click(object sender, EventArgs e) {
			try{
				insert_v_gd_product_price();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

        void m_txt_price_Leave(object sender, EventArgs e)
        {
            try
            {
                if (CIPConvert.is_valid_number(m_txt_price.Text))
                    m_txt_price.Text = CIPConvert.ToStr(
                                        CIPConvert.ToDecimal(m_txt_price.Text), "#,###");
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

	}
}

