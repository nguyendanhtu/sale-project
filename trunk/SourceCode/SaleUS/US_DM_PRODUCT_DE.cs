///************************************************
/// Generated by: linhdh
/// Date: 20/08/2011 05:28:42
/// Goal: Create User Service Class for DM_PRODUCT_DE
///************************************************
/// <summary>
/// Create User Service Class for DM_PRODUCT_DE
/// </summary>


using SaleDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;


namespace SaleUS
{
public class US_DM_PRODUCT_DE : US_Object
{
	private const string c_TableName = "DM_PRODUCT_DE";
#region Public Properties
	public decimal dcID 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID"] = value;
		}
	}

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public string strPRODUCT_CODE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "PRODUCT_CODE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["PRODUCT_CODE"] = value;
		}
	}

	public bool IsPRODUCT_CODENull() 
	{
		return pm_objDR.IsNull("PRODUCT_CODE");
	}

	public void SetPRODUCT_CODENull() {
		pm_objDR["PRODUCT_CODE"] = System.Convert.DBNull;
	}

	public string strPRODUCT_NAME 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "PRODUCT_NAME", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["PRODUCT_NAME"] = value;
		}
	}

	public bool IsPRODUCT_NAMENull() 
	{
		return pm_objDR.IsNull("PRODUCT_NAME");
	}

	public void SetPRODUCT_NAMENull() {
		pm_objDR["PRODUCT_NAME"] = System.Convert.DBNull;
	}

	public string strUNIT_NANE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "UNIT_NANE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["UNIT_NANE"] = value;
		}
	}

	public bool IsUNIT_NANENull() 
	{
		return pm_objDR.IsNull("UNIT_NANE");
	}

	public void SetUNIT_NANENull() {
		pm_objDR["UNIT_NANE"] = System.Convert.DBNull;
	}

	public string strCATEGORY_NAME 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "CATEGORY_NAME", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["CATEGORY_NAME"] = value;
		}
	}

	public bool IsCATEGORY_NAMENull() 
	{
		return pm_objDR.IsNull("CATEGORY_NAME");
	}

	public void SetCATEGORY_NAMENull() {
		pm_objDR["CATEGORY_NAME"] = System.Convert.DBNull;
	}

	public string strDESCRIPTION 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DESCRIPTION", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DESCRIPTION"] = value;
		}
	}

	public bool IsDESCRIPTIONNull() 
	{
		return pm_objDR.IsNull("DESCRIPTION");
	}

	public void SetDESCRIPTIONNull() {
		pm_objDR["DESCRIPTION"] = System.Convert.DBNull;
	}

	public decimal dcCURRENT_PRICE 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "CURRENT_PRICE", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["CURRENT_PRICE"] = value;
		}
	}

	public bool IsCURRENT_PRICENull()	{
		return pm_objDR.IsNull("CURRENT_PRICE");
	}

	public void SetCURRENT_PRICENull() {
		pm_objDR["CURRENT_PRICE"] = System.Convert.DBNull;
	}

#endregion


#region Init Functions
	public US_DM_PRODUCT_DE() 
	{
		pm_objDS = new DS_DM_PRODUCT_DE();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_PRODUCT_DE(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_PRODUCT_DE(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_PRODUCT_DE();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion


  }
}
