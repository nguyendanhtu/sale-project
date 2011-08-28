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
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            PRODUCT_CODE = 1,
            PRODUCT_NAME = 2,
            QUANTITY = 3,
            UNIT_PRICE = 4,
            AMMOUNT = 5
        }

        #endregion

        #region Private Method

        private void format_control()
        {
            CControlFormat.setC1FlexFormat(m_fg);
            m_fg.AllowEditing = true;
            set_define_event();
        }

        private void load_data()
        {
            // Load data to combo box

            // Load data to grid
            m_fg.Redraw = false;
            m_fg.Subtotal(AggregateEnum.Sum, 0, -1, (int)e_col_Number.QUANTITY, "Tổng số sản phẩm");
            m_fg.Subtotal(AggregateEnum.Sum, 0, -1, (int)e_col_Number.AMMOUNT, "Tổng tiền bán hàng");
            m_fg.Redraw = true;


        }

        private void load_product_code_2_combo_list(decimal ip_repository, DateTime ip_date_cur)
        {
            
            US_RPT_BILL_DETAIL_SALES v_us_rpt_bill_details_sales = new US_RPT_BILL_DETAIL_SALES();
            DS_RPT_BILL_DETAIL_SALES v_ds_rpt_bill_details_sales = new DS_RPT_BILL_DETAIL_SALES();

            v_us_rpt_bill_details_sales.FillDataset(v_ds_rpt_bill_details_sales, ip_repository, ip_date_cur); 
            m_fg.Cols["product_code"].ComboList = "";
            for (int i = 0; i < v_ds_rpt_bill_details_sales.RPT_BILL_DETAIL_SALES.Rows.Count; i++)
            {
                m_fg.Cols["product_code"].ComboList += v_ds_rpt_bill_details_sales.RPT_BILL_DETAIL_SALES.Rows[i]["PRODUCT_CODE"].ToString() + "|";
            }
        }

        private Hashtable mapping_data_product(DateTime ip_date_current, decimal ip_repository_id)
        {
            US_RPT_BILL_DETAIL_SALES v_us_rpt_bill_details_sales = new US_RPT_BILL_DETAIL_SALES();
            DS_RPT_BILL_DETAIL_SALES v_ds_rpt_bill_details_sales = new DS_RPT_BILL_DETAIL_SALES();

            v_us_rpt_bill_details_sales.FillDataset(v_ds_rpt_bill_details_sales, ip_repository_id, ip_date_current);
            Hashtable v_obj_hash = new Hashtable();
            for (int i = 0; i < v_ds_rpt_bill_details_sales.RPT_BILL_DETAIL_SALES.Rows.Count; i++)
            {
                v_obj_hash.Add(v_ds_rpt_bill_details_sales.RPT_BILL_DETAIL_SALES.Rows[i]["PRODUCT_CODE"].ToString(),
                new string[2]{v_ds_rpt_bill_details_sales.RPT_BILL_DETAIL_SALES.Rows[i]["PRODUCT_NAME"].ToString()
                    , v_ds_rpt_bill_details_sales.RPT_BILL_DETAIL_SALES.Rows[i]["UNIT_PRICE"].ToString()});
            }

            return v_obj_hash;
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

        private void m_fg_CellChanged(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                if (e.Col == 1)
                {
                    //TODO: Điền bừa mã kho
                    string[] v_arr_values = (string[])mapping_data_product(m_dat_bill_date.Value, 1)[m_fg[e.Row, 1].ToString()];
                    m_fg[e.Row, "product_name"] = v_arr_values[0];
                    m_fg[e.Row, "product_unit_price"] = CIPConvert.ToDecimal(v_arr_values[1]);
                }
                if ((e.Col == 3 || e.Col == 5) && e.Row != 1)
                {
                    m_fg.Redraw = false;
                    m_fg.Subtotal(AggregateEnum.Sum, 0, -1, (int)e_col_Number.QUANTITY, "Tổng số sản phẩm");
                    m_fg.Subtotal(AggregateEnum.Sum, 0, -1, (int)e_col_Number.AMMOUNT, "Tổng tiền bán hàng");
                    m_fg.Redraw = true;
                    m_fg[e.Row, "product_ammount"] = (int)m_fg[e.Row, "product_quantity"] * (decimal)m_fg[e.Row, "product_unit_price"];
                }


            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

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

        #endregion

        #region Data Structure
        #endregion

        #region Event

        void set_define_event()
        {
            this.Load += new EventHandler(f331_xuat_ban_hang_Load);
            m_cmd_add_customer.Click += new EventHandler(m_cmd_add_customer_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
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
                load_data();
                load_product_code_2_combo_list(1, m_dat_bill_date.Value);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion

        
       

     


    }
}

