using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using Sale.CDBNames;
using SaleDS;
using SaleUS;
using C1.Win.C1FlexGrid;

namespace SaleApp
{
    public partial class f331_xuat_ban_hang : Form
    {
        // Constructor
        public f331_xuat_ban_hang()
        {
            InitializeComponent();
            format_control();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }

        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_DM_PRODUCT m_ds_product = new DS_DM_PRODUCT();

        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            PRODUCT_CODE = 1,
            PRODUCT_NAME = 2,
            QUANTITY = 4,
            UNIT_PRICE = 3,
            AMMOUNT = 5
        }

        #endregion

        #region Private Method

        private void format_control()
        {
           // CControlFormat.setC1FlexFormat(m_fg);

            //CControlFormat.setFormStyle(this);
            
            m_fg.AllowEditing = true;
            set_define_event();
            m_lbl_header.ForeColor = Color.Blue;
            m_lbl_header.Font = new Font("Arial", 16);
            m_lbl_address.Font = new Font("Arial", 9);
            
            m_lbl_company_info_address.Font = new Font("Arial", 9);
            
            m_lbl_depository.Font = new Font("Arial", 9);
            m_lbl_customer.Font = new Font("Arial", 9);
            m_lbl_noi_ban.Font = new Font("Arial", 9);
            m_lbl_order_number.Font = new Font("Arial", 9);
            m_lbl_date.Font = new Font("Arial", 9);
        }

        private void set_inital_form_load()
        {
            
            load_data_2_repository();
            mapping_col_product_code();

          
          
        }

        private void load_data_2_repository()
        {
            US_DM_REPOSITORY v_us_repository = new US_DM_REPOSITORY();
            DS_DM_REPOSITORY v_ds_repository = new DS_DM_REPOSITORY();
            v_us_repository.FillDataset(v_ds_repository);
            m_cbo_repository.DataSource = v_ds_repository.DM_REPOSITORY;
            m_cbo_repository.DisplayMember = DM_REPOSITORY.REPOSITORY_NAME;
            m_cbo_repository.ValueMember = DM_REPOSITORY.ID;
        }

        private void mapping_col_product_code()
        {
            US_DM_PRODUCT v_us_product = new US_DM_PRODUCT();
            DS_DM_PRODUCT v_ds_product = new DS_DM_PRODUCT();
            v_us_product.FillDataset(v_ds_product);
            Hashtable v_hst = new Hashtable();
            foreach (DataRow v_dr in v_ds_product.DM_PRODUCT.Rows)
            {
                v_hst.Add(v_dr[DM_PRODUCT.ID], v_dr[DM_PRODUCT.PRODUCT_CODE]);
            }

            m_fg.Cols[(int)e_col_Number.PRODUCT_CODE].DataMap = v_hst;
            m_ds_product = (DS_DM_PRODUCT)v_ds_product.Copy();

        }

                #region Error
        //private ITransferDataRow get_mapping_grid_col()
        //{
        //    Hashtable v_obj_hash = new Hashtable();
        //    v_obj_hash.Add(RPT_BILL_DETAIL_SALES.PRODUCT_CODE, e_col_Number.PRODUCT_CODE);
        //    v_obj_hash.Add(RPT_BILL_DETAIL_SALES.PRODUCT_NAME, e_col_Number.PRODUCT_NAME);
        //    v_obj_hash.Add(RPT_BILL_DETAIL_SALES.QUANTITY, e_col_Number.QUANTITY);
        //    v_obj_hash.Add(RPT_BILL_DETAIL_SALES.UNIT_PRICE, e_col_Number.UNIT_PRICE); 
        //    v_obj_hash.Add(RPT_BILL_DETAIL_SALES.COST, e_col_Number.COST);

        //    DS_RPT_BILL_DETAIL_SALES v_ds_rpt_bill_details_sales = new DS_RPT_BILL_DETAIL_SALES();

        //    return new CC1TransferDataRow(m_fg, v_obj_hash, v_ds_rpt_bill_details_sales.RPT_BILL_DETAIL_SALES.NewRPT_BILL_DETAIL_SALESRow());
        //}
        #endregion

        

        private bool check_validate_data_is_ok()
        {
            return true;
        }

        private void grid_2_us_object(int i_grid_row, US_RPT_BILL_DETAIL_SALES op_us_object)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            op_us_object.DataRow2Me(v_dr);
        }

        private void save_data()
        {
            if (!check_validate_data_is_ok())
                return;

            US_RPT_BILL_DETAIL_SALES v_us_rpt_bill_detail_sales = new US_RPT_BILL_DETAIL_SALES();
            for (int v_i_cur_row = m_fg.Rows.Fixed + 1; v_i_cur_row < m_fg.Rows.Count; v_i_cur_row++)
            {
                grid_2_us_object(v_i_cur_row, v_us_rpt_bill_detail_sales);
                v_us_rpt_bill_detail_sales.Insert();
            }
            BaseMessages.MsgBox_Infor(10);
        }

        private void calculate_total_amount()
        {
            decimal v_dc_total_price = 0;
            for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count; v_i_cur_row++)
            {
                if (m_fg[v_i_cur_row, (int)e_col_Number.AMMOUNT] == null) continue;
                if (CIPConvert.is_valid_number(m_fg[v_i_cur_row, (int)e_col_Number.AMMOUNT]) == false) continue;
                v_dc_total_price += CIPConvert.ToDecimal(m_fg[v_i_cur_row, (int)e_col_Number.AMMOUNT]);
            }
            m_txt_total_price.Text = CIPConvert.ToStr(v_dc_total_price, "#,###");
        }

        #endregion


        #region Event

        void set_define_event()
        {
            this.Load += new EventHandler(f331_xuat_ban_hang_Load);
            m_cmd_add_customer.Click += new EventHandler(m_cmd_add_customer_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            this.m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.m_fg.CellChanged += new C1.Win.C1FlexGrid.RowColEventHandler(this.m_fg_CellChanged);
            this.m_cmd_remove_row.Click += new EventHandler(m_cmd_remove_row_Click);
           
        }

        void m_cmd_remove_row_Click(object sender, EventArgs e)
        {
            try
            {
                m_fg.Rows.Remove(m_fg.Row);
                calculate_total_amount();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

     

        

       
        private void m_fg_CellChanged(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                //1. Tự động đưa thông tin về tên sản phẩm và giá thành
                if (e.Col == (int)e_col_Number.PRODUCT_CODE)
                {
                    DataRow[] v_dr_product = m_ds_product.DM_PRODUCT.Select(DM_PRODUCT.ID + " = " + m_fg[e.Row, (int)e_col_Number.PRODUCT_CODE].ToString());
                    if (v_dr_product.Length == 0) return;// Neu khong co' trong ban PRODUCT thi phai thoat luon? Nhung cha'c cha'n la sai do'
                    m_fg[e.Row, (int)e_col_Number.PRODUCT_NAME] = v_dr_product[0][DM_PRODUCT.PRODUCT_NAME];
                    m_fg[e.Row, (int)e_col_Number.UNIT_PRICE] = v_dr_product[0][DM_PRODUCT.CURRENT_PRICE];
                    m_fg.Col = (int)e_col_Number.QUANTITY;
                }

                if (m_fg[e.Row, (int)e_col_Number.UNIT_PRICE] == null) return;
                if (m_fg[e.Row, (int)e_col_Number.QUANTITY] == null) return;
                if (CIPConvert.is_valid_number(m_fg[e.Row, (int)e_col_Number.UNIT_PRICE]) == false) return;
                if (CIPConvert.is_valid_number(m_fg[e.Row, (int)e_col_Number.QUANTITY]) == false) return;
                // 2. Tự động tính thông tin thành tiền trên từng dòng
                m_fg[e.Row, (int)e_col_Number.AMMOUNT]
                    = CIPConvert.ToDecimal(m_fg[e.Row, (int)e_col_Number.UNIT_PRICE])
                        * CIPConvert.ToDecimal(m_fg[e.Row, (int)e_col_Number.QUANTITY]);
                //3. Tự động tính tổng tiền bán
                calculate_total_amount();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_add_customer_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f331_xuat_ban_hang_Load(object sender, EventArgs e)
        {
            try
            {
                set_inital_form_load();
               
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion

        
       

     


    }
}

