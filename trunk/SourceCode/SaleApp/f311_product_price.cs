﻿using System;
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
    public partial class f311_product_price : Form
    {
        public f311_product_price()
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
