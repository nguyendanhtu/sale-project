///************************************************
/// Generated by: Uyvq
/// Date: 30/08/2011 08:35:12
/// Goal: Create Form for V_RPT_DELIVERY_ODER
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
using IP.Core.IPExcelReport;
using C1.Win.C1FlexGrid;

namespace SaleApp
{



	public class f961_bao_cao_xuat_nhap_trong_ky : System.Windows.Forms.Form
	{
        internal System.Windows.Forms.ImageList ImageList;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_export_excel;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private GroupBox m_grb_thong_tin_ban_hang;
        private ComboBox m_cbo_repository;
        private Label m_lbl_repository;
        private ComboBox m_cbo_ten_mat_hang;
        private Label m_lbl_product_name;
        private DateTimePicker m_dat_to_date;
        internal SIS.Controls.Button.SiSButton m_cmd_view;
        private Label label2;
        private Label label1;
        private DateTimePicker m_dat_from_date;
		private System.ComponentModel.IContainer components;

		public f961_bao_cao_xuat_nhap_trong_ky()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f961_bao_cao_xuat_nhap_trong_ky));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_export_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_grb_thong_tin_ban_hang = new System.Windows.Forms.GroupBox();
            this.m_cbo_ten_mat_hang = new System.Windows.Forms.ComboBox();
            this.m_lbl_product_name = new System.Windows.Forms.Label();
            this.m_dat_to_date = new System.Windows.Forms.DateTimePicker();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_dat_from_date = new System.Windows.Forms.DateTimePicker();
            this.m_cbo_repository = new System.Windows.Forms.ComboBox();
            this.m_lbl_repository = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.m_grb_thong_tin_ban_hang.SuspendLayout();
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
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 119);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(695, 289);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_export_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 408);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(695, 36);
            this.m_pnl_out_place_dm.TabIndex = 29;
            // 
            // m_cmd_export_excel
            // 
            this.m_cmd_export_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_export_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_export_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_export_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_export_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_export_excel.ImageIndex = 19;
            this.m_cmd_export_excel.ImageList = this.ImageList;
            this.m_cmd_export_excel.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_export_excel.Name = "m_cmd_export_excel";
            this.m_cmd_export_excel.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_export_excel.TabIndex = 21;
            this.m_cmd_export_excel.Text = "Xuất excel";
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
            this.m_cmd_exit.Location = new System.Drawing.Point(603, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_grb_thong_tin_ban_hang
            // 
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_cbo_repository);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_lbl_repository);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_cbo_ten_mat_hang);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_lbl_product_name);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_dat_to_date);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_cmd_view);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.label2);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.label1);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_dat_from_date);
            this.m_grb_thong_tin_ban_hang.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_grb_thong_tin_ban_hang.Location = new System.Drawing.Point(0, 0);
            this.m_grb_thong_tin_ban_hang.Name = "m_grb_thong_tin_ban_hang";
            this.m_grb_thong_tin_ban_hang.Size = new System.Drawing.Size(695, 119);
            this.m_grb_thong_tin_ban_hang.TabIndex = 28;
            this.m_grb_thong_tin_ban_hang.TabStop = false;
            this.m_grb_thong_tin_ban_hang.Text = "Thông tin bán hàng";
            // 
            // m_cbo_ten_mat_hang
            // 
            this.m_cbo_ten_mat_hang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_cbo_ten_mat_hang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.m_cbo_ten_mat_hang.FormattingEnabled = true;
            this.m_cbo_ten_mat_hang.Location = new System.Drawing.Point(132, 81);
            this.m_cbo_ten_mat_hang.MaxDropDownItems = 5;
            this.m_cbo_ten_mat_hang.Name = "m_cbo_ten_mat_hang";
            this.m_cbo_ten_mat_hang.Size = new System.Drawing.Size(200, 21);
            this.m_cbo_ten_mat_hang.TabIndex = 31;
            // 
            // m_lbl_product_name
            // 
            this.m_lbl_product_name.AutoSize = true;
            this.m_lbl_product_name.Location = new System.Drawing.Point(65, 84);
            this.m_lbl_product_name.Name = "m_lbl_product_name";
            this.m_lbl_product_name.Size = new System.Drawing.Size(55, 13);
            this.m_lbl_product_name.TabIndex = 30;
            this.m_lbl_product_name.Text = "Sản phẩm";
            // 
            // m_dat_to_date
            // 
            this.m_dat_to_date.CustomFormat = "dd/MM/yyyy";
            this.m_dat_to_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_to_date.Location = new System.Drawing.Point(406, 43);
            this.m_dat_to_date.Name = "m_dat_to_date";
            this.m_dat_to_date.Size = new System.Drawing.Size(165, 20);
            this.m_dat_to_date.TabIndex = 26;
            // 
            // m_cmd_view
            // 
            this.m_cmd_view.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_view.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_view.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_view.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_view.ImageIndex = 5;
            this.m_cmd_view.ImageList = this.ImageList;
            this.m_cmd_view.Location = new System.Drawing.Point(604, 16);
            this.m_cmd_view.Name = "m_cmd_view";
            this.m_cmd_view.Size = new System.Drawing.Size(88, 100);
            this.m_cmd_view.TabIndex = 29;
            this.m_cmd_view.Text = "In báo cáo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Từ ngày";
            // 
            // m_dat_from_date
            // 
            this.m_dat_from_date.CustomFormat = "dd/MM/yyyy";
            this.m_dat_from_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_from_date.Location = new System.Drawing.Point(132, 42);
            this.m_dat_from_date.Name = "m_dat_from_date";
            this.m_dat_from_date.Size = new System.Drawing.Size(200, 20);
            this.m_dat_from_date.TabIndex = 24;
            // 
            // m_cbo_repository
            // 
            this.m_cbo_repository.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_cbo_repository.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.m_cbo_repository.FormattingEnabled = true;
            this.m_cbo_repository.Location = new System.Drawing.Point(409, 84);
            this.m_cbo_repository.MaxDropDownItems = 5;
            this.m_cbo_repository.Name = "m_cbo_repository";
            this.m_cbo_repository.Size = new System.Drawing.Size(162, 21);
            this.m_cbo_repository.TabIndex = 33;
            // 
            // m_lbl_repository
            // 
            this.m_lbl_repository.AutoSize = true;
            this.m_lbl_repository.Location = new System.Drawing.Point(348, 89);
            this.m_lbl_repository.Name = "m_lbl_repository";
            this.m_lbl_repository.Size = new System.Drawing.Size(26, 13);
            this.m_lbl_repository.TabIndex = 32;
            this.m_lbl_repository.Text = "Kho";
            // 
            // f961_bao_cao_xuat_nhap_trong_ky
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(695, 444);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.m_grb_thong_tin_ban_hang);
            this.Name = "f961_bao_cao_xuat_nhap_trong_ky";
            this.Text = "f961_bao_cao_xuat_nhap_trong_ky";
            this.Load += new System.EventHandler(this.f961_bao_cao_xuat_nhap_trong_ky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.m_grb_thong_tin_ban_hang.ResumeLayout(false);
            this.m_grb_thong_tin_ban_hang.PerformLayout();
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
			QUANTITY = 4,UNIT_CODE = 5,QUANTITY_OUT = 6,QUANTITY_IN = 7,PRODUCT_NAME = 3,PRODUCT_CODE = 2,DELIVERY_ORDER_DATE = 1
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_RPT_DELIVERY_ODER m_ds = new DS_V_RPT_DELIVERY_ODER();
		US_V_RPT_DELIVERY_ODER m_us = new US_V_RPT_DELIVERY_ODER();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this);
			CControlFormat.setC1FlexFormat(m_fg);
			CGridUtils.AddSave_Excel_Handlers(m_fg);
			CGridUtils.AddSearch_Handlers(m_fg);
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_RPT_DELIVERY_ODER.QUANTITY, e_col_Number.QUANTITY);			v_htb.Add(V_RPT_DELIVERY_ODER.UNIT_CODE, e_col_Number.UNIT_CODE);			v_htb.Add(V_RPT_DELIVERY_ODER.QUANTITY_OUT, e_col_Number.QUANTITY_OUT);			v_htb.Add(V_RPT_DELIVERY_ODER.QUANTITY_IN, e_col_Number.QUANTITY_IN);			v_htb.Add(V_RPT_DELIVERY_ODER.PRODUCT_NAME, e_col_Number.PRODUCT_NAME);			v_htb.Add(V_RPT_DELIVERY_ODER.PRODUCT_CODE, e_col_Number.PRODUCT_CODE);			v_htb.Add(V_RPT_DELIVERY_ODER.DELIVERY_ORDER_DATE, e_col_Number.DELIVERY_ORDER_DATE);									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_RPT_DELIVERY_ODER.NewRow());
			return v_obj_trans;			
		}
        private void load_data_to_m_cbo_ten_mat_hang() 
        {
            US_DM_PRODUCT v_us_dm_product = new US_DM_PRODUCT();
            DS_DM_PRODUCT v_ds_dm_product = new DS_DM_PRODUCT();
            v_us_dm_product.FillDataset(v_ds_dm_product);
            v_ds_dm_product.EnforceConstraints = false;
            m_cbo_ten_mat_hang.DisplayMember = DM_PRODUCT.PRODUCT_NAME;
            m_cbo_ten_mat_hang.ValueMember = DM_PRODUCT.ID;
            m_cbo_ten_mat_hang.DataSource = v_ds_dm_product.DM_PRODUCT;
        }
        private void load_data_to_m_cbo_repository()
        {
            US_DM_REPOSITORY v_us_dm_product = new US_DM_REPOSITORY();
            DS_DM_REPOSITORY v_ds_dm_product = new DS_DM_REPOSITORY();
            v_us_dm_product.FillDataset(v_ds_dm_product);
            v_ds_dm_product.EnforceConstraints = false;
            m_cbo_repository.DisplayMember = DM_REPOSITORY.REPOSITORY_NAME;
            m_cbo_repository.ValueMember = DM_REPOSITORY.ID;
            m_cbo_repository.DataSource = v_ds_dm_product.DM_REPOSITORY;
        
        }
		private void load_data_2_grid(){						
			m_ds = new DS_V_RPT_DELIVERY_ODER();			
			m_us.FillDataset(
                m_ds
                ,CIPConvert.ToDecimal(m_cbo_ten_mat_hang.SelectedValue)
                ,m_dat_from_date.Value.Date,m_dat_to_date.Value.Date
                ,CIPConvert.ToDecimal(m_cbo_repository.SelectedValue));
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
			m_fg.Redraw = true;
		}
        
		private void grid2us_object(US_V_RPT_DELIVERY_ODER i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_RPT_DELIVERY_ODER i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}

        private void export_excel()
        {
            CExcelReport v_obj_export_excel = new CExcelReport("f961_rpt_bao_cao_xuat_nhap_theo_ky.xlsx", 6, 1);
            v_obj_export_excel.AddFindAndReplaceItem("</TU_NGAY>", m_dat_from_date.Value.Date.ToString("dd/MM/yyyy"));
            v_obj_export_excel.AddFindAndReplaceItem("</DEN_NGAY>", m_dat_to_date.Value.Date.ToString("dd/MM/yyyy"));
            v_obj_export_excel.AddFindAndReplaceItem("</SAN_PHAM>", m_cbo_ten_mat_hang.Text);
            v_obj_export_excel.FindAndReplace(false);
            v_obj_export_excel.Export2ExcelWithoutFixedRows(m_fg, (int)e_col_Number.DELIVERY_ORDER_DATE, m_fg.Cols.Count - 1, true);


        }
       
		
		private void view_v_rpt_delivery_oder(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f961_bao_cao_xuat_nhap_trong_ky_DE v_fDE = new f961_bao_cao_xuat_nhap_trong_ky_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_export_excel.Click += new EventHandler(m_cmd_export_excel_Click);
			m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            m_dat_from_date.ValueChanged += new EventHandler(m_dat_from_date_ValueChanged);
            m_dat_to_date.ValueChanged += new EventHandler(m_dat_to_date_ValueChanged);
		}


        
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f961_bao_cao_xuat_nhap_trong_ky_Load(object sender, System.EventArgs e) {
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
        private void m_cmd_export_excel_Click(object sender, EventArgs e)
        {
            try
            {
                export_excel();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

       private  void m_dat_to_date_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

       private void m_dat_from_date_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
	
		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_v_rpt_delivery_oder();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

	}
}

