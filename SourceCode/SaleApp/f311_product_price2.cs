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
    public partial class f311_product_price2 : Form
    {
        public f311_product_price2()
        {
            InitializeComponent();
            setdefineevents();
        }
        #region Private Method
        private void load_data_2_cbo()
        {
            US_DM_PRODUCT v_us_product = new US_DM_PRODUCT();
            DS_DM_PRODUCT v_ds_product = new DS_DM_PRODUCT();
            v_us_product.FillDataset(v_ds_product, " ORDER BY " + DM_PRODUCT.ID);
            v_ds_product.EnforceConstraints = false;
            DataRow v_dr_default = v_ds_product.DM_PRODUCT.NewDM_PRODUCTRow();


            v_dr_default[DM_PRODUCT.ID] = -1;
            v_dr_default[DM_PRODUCT.PRODUCT_NAME] = "Không có cấp trên";
            v_ds_product.DM_PRODUCT.Rows.InsertAt(v_dr_default, 0);

            m_cbo_product_name.DisplayMember = DM_PRODUCT_DE.PRODUCT_NAME;
            m_cbo_product_name.ValueMember = DM_PRODUCT_DE.ID;
            m_cbo_product_name.DataSource = v_ds_product.DM_PRODUCT;

        }
        private void setdefineevents()
        {
            this.Load += new EventHandler(f311_product_price_Load);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
        }


        #region Private Methods

        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg);
            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(GD_PRODUCT_PRICE.UNIT_ID, e_col_Number.UNIT_ID);
            v_htb.Add(GD_PRODUCT_PRICE.PRICE, e_col_Number.PRICE);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.GD_PRODUCT_PRICE.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_GD_PRODUCT_PRICE();
            m_us.FillDataset(m_ds);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_GD_PRODUCT_PRICE i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_GD_PRODUCT_PRICE i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_gd_product_price()
        {
            //	frm_GD_PRODUCT_PRICE2_DE v_fDE = new  frm_GD_PRODUCT_PRICE2_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_gd_product_price()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	frm_GD_PRODUCT_PRICE2_DE v_fDE = new frm_GD_PRODUCT_PRICE2_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_gd_product_price()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_GD_PRODUCT_PRICE v_us = new US_GD_PRODUCT_PRICE();
            grid2us_object(v_us, m_fg.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_gd_product_price()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	frm_GD_PRODUCT_PRICE2_DE v_fDE = new frm_GD_PRODUCT_PRICE2_DE();			
            //	v_fDE.display(m_us);
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
        }
        #endregion
      
        public void display()
        {
            this.ShowDialog();
        }
        #endregion
        #region Events
        void f311_product_price_Load(object sender, EventArgs e)
        {
            try
            {

                load_data_2_cbo();
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
        #endregion
    }
}
