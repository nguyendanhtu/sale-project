using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Configuration;


using System.Collections;


using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;


namespace SaleApp
{
    public partial class f001_main_form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private IContainer components;

        public f001_main_form()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            format_controls();
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.BonusSkins).Assembly);
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.OfficeSkins).Assembly);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

      



        #region public Interface
        public void display(ref IPConstants.HowUserWantTo_Exit_MainForm o_exitMode)
        {
            this.ShowDialog();
            o_exitMode = m_exitMode;
        }

        #endregion
        #region Data Structures

        #endregion

        #region Members

        IPConstants.HowUserWantTo_Exit_MainForm m_exitMode = IPConstants.HowUserWantTo_Exit_MainForm.ExitFromSystem;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);

            set_define_events();
        }

        private void show_manager_user()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.BACK_UP_AND_RESTORE))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được quyền truy nhập phần này !!! ");
                return;
            }
            f999_ht_nguoi_su_dung v_frm_999 = new f999_ht_nguoi_su_dung();
            v_frm_999.display();
        }
        private void show_product_price()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.BACK_UP_AND_RESTORE))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được quyền truy nhập phần này !!! ");
                return;
            }
            f311_product_price v_frm_311 = new f311_product_price();
            v_frm_311.display();
        }
        private void show_introduction()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f996_license_form v_frm996 = new f996_license_form();
            v_frm996.display();
            //			IP.Core.IPSystemAdmin.f996_license v_frm = new f996_license () ;
            //			v_frm.display () ;
        }

        private void show_tu_dien_phan_quyen()
        {
            //if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.CHUC_NANG))
            //{
            //    BaseMessages.MsgBox_Infor(" Người sử dụng không có quyền truy nhập phần này ! ");
            //    return;
            //}
            f100_TuDien v_frm = new f100_TuDien();
            v_frm.ShowDialog();
        }

        private void set_inital_form_load()
        {

        }
        private void show_category()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f201_dm_category v_frm201 = new f201_dm_category();
            v_frm201.display();
        }

        private void show_product()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }

            f301_dm_produc v_frm301 = new f301_dm_produc();
            v_frm301.display();
        }

        /// <summary>
        /// Show form danh mục quản lý đơn vị 
        /// </summary>
        private void show_unit_product()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }

            h v_frm901 = new h();
            v_frm901.display();
        }
        private void show_provider()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }

            f701_dm_provider v_frm701 = new f701_dm_provider();
            v_frm701.display();
        }
        private void show_repository()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }

            f801_dm_repository v_frm801 = new f801_dm_repository();
            v_frm801.display();
        }
        #endregion
        //
        //
        //   event handlers
        //
        //
        private void set_define_events()
        {


        }

     

        private void mnu_user_management_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_manager_user();

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void mnu_directory_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                show_tu_dien_phan_quyen();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
           
        }


        private void mnu_type_of_directory_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {


            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (BaseMessages.MsgBox_Confirm("Bạn có thật sự muốn kết thúc chương trình không ? "))
                {
                    m_exitMode = IPConstants.HowUserWantTo_Exit_MainForm.ExitFromSystem;
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_category_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_category();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_product_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_product();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_dm_unit_product_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_unit_product();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_license_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                show_introduction();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_dm_repository_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_repository();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void mnu_dm_provider_ItemClick(object sender, ItemClickEventArgs e)
        {

            try
            {

                show_provider();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_product_price_ItemClick(object sender, ItemClickEventArgs e)
        {
             try
            {

                show_product_price();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
           
        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            string SkinName = barEditItem1.EditValue.ToString();//lấy tên giao diện được chọn.
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SkinName);//đổi giao diện thành giao diện được chọn.            
            //lưu giao diện được chọn vào file config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["SkinName"].Value = SkinName;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSetting");
        }

        private void f001_main_form_Load(object sender, EventArgs e)
        {
            string SkinName = ConfigurationManager.AppSettings["SkinName"];//lấy tên giao diện được chọn đã lưu trong file config
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SkinName);
            barEditItem1.EditValue = SkinName;
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        
        
    
     
    }
}