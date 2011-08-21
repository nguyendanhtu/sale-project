﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;

using SaleUS;
using SaleDS;
using Sale.CDBNames;

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
            US_DM_PRODUCT_DE v_us_product = new US_DM_PRODUCT_DE();
            DS_DM_PRODUCT_DE v_ds_product = new DS_DM_PRODUCT_DE();
            v_us_product.FillDataset(v_ds_product, " ORDER BY " + DM_PRODUCT_DE.PRODUCT_NAME);
            v_ds_product.EnforceConstraints = false;
            DataRow v_dr_default = v_ds_product.DM_PRODUCT_DE.NewDM_PRODUCT_DERow();
            v_dr_default[DM_PRODUCT_DE.ID] = -1;
            v_dr_default[DM_PRODUCT_DE.PRODUCT_NAME] = "Không có cấp trên";
            v_ds_product.DM_PRODUCT_DE.Rows.InsertAt(v_dr_default, 0);

            m_cbo_product_name.DisplayMember = DM_PRODUCT_DE.PRODUCT_NAME;
            m_cbo_product_name.ValueMember = DM_PRODUCT_DE.PROVIDER_ID;
            m_cbo_product_name.DataSource = v_ds_product.DM_PRODUCT_DE;

        }
        private void setdefineevents()
        {
            this.Load += new EventHandler(f311_product_price_Load);
        }

      
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
        #endregion
    }
}
