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

namespace SaleApp
{
    public partial class f321_nhap_so_du_hang_hoa : Form
    {
        public f321_nhap_so_du_hang_hoa()
        {
            InitializeComponent();
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
        }

       

        private void set_initial_form_load()
        {
            CControlFormat.setFormStyle(this);
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
        #endregion

        private void f321_nhap_so_du_hang_hoa_Load(object sender, EventArgs e)
        {

        }

    }
}
