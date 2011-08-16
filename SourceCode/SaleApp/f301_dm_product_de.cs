using System;
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
    public partial class f301_dm_product_de : Form
    {
        public f301_dm_product_de()
        {
            InitializeComponent();
            format_controls();
            set_define_events();
        }

       

        #region Public Interface

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US_DM_PRODUCT ip_us_product)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_product = ip_us_product;
            this.ShowDialog();
        }

        public void display()
        {
            m_e_form_mode = DataEntryFormMode.ViewDataState;
            this.ShowDialog();
        }

      

        #endregion 

        #region Members
        US_DM_PRODUCT m_us_product = new US_DM_PRODUCT();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion

        #region Method
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            this.KeyPreview = true;
        }

        private void load_data_2_cbo()
        {
            US_DM_PRODUCT v_us_product = new US_DM_PRODUCT();
            DS_DM_PRODUCT v_ds_product = new DS_DM_PRODUCT();
            v_us_product.FillDataset(v_ds_product);
            v_ds_product.EnforceConstraints = false;


            m_cbo_unit.DisplayMember = DM_UNIT.UNIT_CODE;
            m_cbo_unit.ValueMember = DM_UNIT.ID;
            //m_cbo_unit.DataSource = v
        }

        private void us_object_2_form(US_DM_PRODUCT ip_us_product)
        {
            m_txt_product_code.Text = ip_us_product.strPRODUCT_CODE;
            m_txt_product_name.Text = ip_us_product.strPRODUCT_NAME;
            
        }

        private void form_2_us_object(US_DM_PRODUCT op_us_category)
        { }


        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            this.Load += new EventHandler(f301_dm_product_de_Load);
        }
        #endregion


        // ======================
        //============Event =========
        //==========================
        void f301_dm_product_de_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void m_cmd_exit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        

    }
}
