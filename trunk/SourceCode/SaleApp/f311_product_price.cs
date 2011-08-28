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
    public partial class f311_product_price : Form
    {
        public f311_product_price()
        {
            InitializeComponent();
            format_controls();
            setdefineevents();
        }
        #region Private Method
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            CControlFormat.setLabelStyle(m_lbl_catalogy, CControlFormat.LabelStyle.Title_Info);
            CControlFormat.setLabelStyle(m_lbl_price, CControlFormat.LabelStyle.Title_Info);
            CControlFormat.setLabelStyle(m_lbl_price_date, CControlFormat.LabelStyle.Title_Info);
            CControlFormat.setLabelStyle(m_lbl_product_name, CControlFormat.LabelStyle.Title_Info);
            mlbl_add_category.ForeColor = Color.Blue;
            mlbl_add_category.Font = new Font("Arial", 16);
        }
        private void load_data_2_cbo_product()
        {
            US_DM_PRODUCT v_us_product = new US_DM_PRODUCT();
            DS_DM_PRODUCT v_ds_product = new DS_DM_PRODUCT();
            v_us_product.FillDataset(v_ds_product, " ORDER BY " + DM_PRODUCT.ID);
            v_ds_product.EnforceConstraints = false;

            m_cbo_product_name.DisplayMember = DM_PRODUCT_DE.PRODUCT_NAME;
            m_cbo_product_name.ValueMember = DM_PRODUCT_DE.ID;
            m_cbo_product_name.DataSource = v_ds_product.DM_PRODUCT;

        }
        private void load_data_2_cbo_catalogy()
        {
            US_DM_CATEGORY v_us_catalogy = new US_DM_CATEGORY();
            DS_DM_CATEGORY v_ds_catalogy = new DS_DM_CATEGORY();
            v_us_catalogy.FillDataset(v_ds_catalogy, " ORDER BY " + DM_CATEGORY.ID);
            v_ds_catalogy.EnforceConstraints = false;
            DataRow v_dr_default = v_ds_catalogy.DM_CATEGORY.NewDM_CATEGORYRow();


            v_dr_default[DM_CATEGORY.ID] = -1;
            v_dr_default[DM_CATEGORY.CATEGORY_NAME] = "Không có cấp trên";
            v_ds_catalogy.DM_CATEGORY.Rows.InsertAt(v_dr_default, 0);

            m_cbo_catalogy .DisplayMember = DM_CATEGORY.CATEGORY_NAME;
            m_cbo_catalogy.ValueMember = DM_PRODUCT_DE.ID;
            m_cbo_catalogy.DataSource = v_ds_catalogy.DM_CATEGORY;

        }
        private void setdefineevents()
        {
            this.Load += new EventHandler(f311_product_price_Load);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_txt_price.Leave += new EventHandler(m_txt_price_Leave);
        }

        #endregion

        #region pulic
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

                load_data_2_cbo_product();
                load_data_2_cbo_catalogy();
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


        void m_txt_price_Leave(object sender, EventArgs e)
        {
            try
            {
                if (CIPConvert.is_valid_number(m_txt_price.Text))
                   m_txt_price.Text=CIPConvert.ToStr(
                        CIPConvert.ToDecimal(m_txt_price.Text), "#,###");
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
