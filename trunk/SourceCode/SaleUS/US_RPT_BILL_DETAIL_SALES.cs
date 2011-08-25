///************************************************
/// Generated by: tund
/// Date: 25/08/2011 09:32:07
/// Goal: Create User Service Class for RPT_BILL_DETAIL_SALES
///************************************************
/// <summary>
/// Create User Service Class for RPT_BILL_DETAIL_SALES
/// </summary>


using SaleDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;


namespace SaleUS
{
public class US_RPT_BILL_DETAIL_SALES : US_Object
{
	private const string c_TableName = "RPT_BILL_DETAIL_SALES";
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

	public decimal dcPRODUCT_ID 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "PRODUCT_ID", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["PRODUCT_ID"] = value;
		}
	}

	public bool IsPRODUCT_IDNull()	{
		return pm_objDR.IsNull("PRODUCT_ID");
	}

	public void SetPRODUCT_IDNull() {
		pm_objDR["PRODUCT_ID"] = System.Convert.DBNull;
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

	public decimal dcQUANTITY 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "QUANTITY", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["QUANTITY"] = value;
		}
	}

	public bool IsQUANTITYNull()	{
		return pm_objDR.IsNull("QUANTITY");
	}

	public void SetQUANTITYNull() {
		pm_objDR["QUANTITY"] = System.Convert.DBNull;
	}

	public decimal dcUNIT_PRICE 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "UNIT_PRICE", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["UNIT_PRICE"] = value;
		}
	}

	public bool IsUNIT_PRICENull()	{
		return pm_objDR.IsNull("UNIT_PRICE");
	}

	public void SetUNIT_PRICENull() {
		pm_objDR["UNIT_PRICE"] = System.Convert.DBNull;
	}

	public decimal dcCOST 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "COST", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["COST"] = value;
		}
	}

	public bool IsCOSTNull()	{
		return pm_objDR.IsNull("COST");
	}

	public void SetCOSTNull() {
		pm_objDR["COST"] = System.Convert.DBNull;
	}

#endregion


#region Init Functions
	public US_RPT_BILL_DETAIL_SALES() 
	{
		pm_objDS = new DS_RPT_BILL_DETAIL_SALES();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_RPT_BILL_DETAIL_SALES(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_RPT_BILL_DETAIL_SALES(decimal i_dbID) 
	{
		pm_objDS = new DS_RPT_BILL_DETAIL_SALES();
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
