using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPException;
using IP.Core.IPCommon;
using IP.Core.IPUserService;

using SaleUS;
using SaleDS;
using Sale.CDBNames;

namespace SaleApp
{
    public partial class f321_nhap_so_du_hang_hoa : Form
    {
        public f321_nhap_so_du_hang_hoa()
        {
            InitializeComponent();
            set_initial_form_load();
            set_define_events();
        }

        #region Members
        #endregion

        #region Public Interfaces
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Private Methods
        private void set_define_events()
        {
            m_dtime_ngay_nhap.EditValueChanged += new EventHandler(m_date_time_picker_EditValueChanged);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cbo_product.SelectedIndexChanged += new EventHandler(m_cbo_product_SelectedIndexChanged);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
        }

        
        private void Load_data_to_string_to_cbo()
        {
            US_DM_PRODUCT v_us_dm_product = new US_DM_PRODUCT();
            DS_DM_PRODUCT v_ds_dm__product = new DS_DM_PRODUCT();

            v_us_dm_product.FillDataset(v_ds_dm__product,"ORDER BY "+DM_PRODUCT.CATEGORY_ID);
            m_cbo_product.DisplayMember = DM_PRODUCT.PRODUCT_NAME;
            m_cbo_product.ValueMember = DM_PRODUCT.ID;
            m_cbo_product.DataSource = v_ds_dm__product.DM_PRODUCT;
        }
        private DS_DM_PRODUCT Load_product_by_id(int ip_i_product_id)
        {
            US_DM_PRODUCT v_us_dm_product = new US_DM_PRODUCT();
            DS_DM_PRODUCT v_ds_dm_product = new DS_DM_PRODUCT();

            v_us_dm_product.FillDataset(v_ds_dm_product, "WHERE ID="+ip_i_product_id);
            return v_ds_dm_product;
        }

        private void set_initial_form_load()
        {
            CControlFormat.setFormStyle(this);
            Load_data_to_string_to_cbo();

            US_DM_UNIT v_us_dm_unit = new US_DM_UNIT();
            DS_DM_UNIT v_ds_unit = new DS_DM_UNIT();
            
            v_us_dm_unit.FillDataset(v_ds_unit);
            m_fg.Cols[2].ComboList = "";
            
            for (int i = 0; i < v_ds_unit.DM_UNIT.Rows.Count; i++)
            {
                m_fg.Cols["unit_code"].ComboList += v_ds_unit.DM_UNIT.Rows[i]["UNIT_CODE"].ToString() + "|";
            }
        }
        private void check_data_validate()
        {
           
        }
        #endregion

        #region Events      
        void m_date_time_picker_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
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
        void m_cbo_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var v_i_product_id =  int.Parse(m_cbo_product.SelectedValue.ToString());
                DS_DM_PRODUCT v_ds_dm_product = new DS_DM_PRODUCT();
                v_ds_dm_product= this.Load_product_by_id(v_i_product_id);
                object[] v_obj_items = new object[2];
                v_obj_items[0] = v_ds_dm_product.DM_PRODUCT.Rows[0][0];
                v_obj_items[1] = v_ds_dm_product.DM_PRODUCT.Rows[0][1];
                
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                BaseMessages.MsgBox_Infor(10);
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
