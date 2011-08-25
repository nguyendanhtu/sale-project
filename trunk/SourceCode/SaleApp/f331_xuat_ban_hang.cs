using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;

namespace SaleApp
{
    public partial class f331_xuat_ban_hang : Form
    {
        public f331_xuat_ban_hang()
        {   
            InitializeComponent();
            format_control();
            set_define_event();
        }


        #region Public Interface

        #endregion


        #region Private Method
        private void format_control()
        {
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg);
            this.KeyPreview = true;
        }

        private void set_define_event()
        {
            this.Load += new EventHandler(f331_xuat_ban_hang_Load);
            m_cmd_add_customer.Click += new EventHandler(m_cmd_add_customer_Click);
        }

       
        private void save_data()
        {

        }

        #endregion


        #region Members
        #endregion


        #region Data Structure
        #endregion


        #region Event

        void f331_xuat_ban_hang_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void m_cmd_add_customer_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void m_cmd_add_product_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void m_cmd_exit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void m_cmd_add_product_2_bill_Click(object sender, EventArgs e)
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


        #endregion

        private void m_dat_bill_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void m_lbl_company_info_address_Click(object sender, EventArgs e)
        {

        }

        private void f331_xuat_ban_hang_Load_1(object sender, EventArgs e)
        {

        }

        private void m_txt_tax_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void m_cmd_add_customer_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }





        public void display()
        {
            this.ShowDialog();
        }
    }
}

