using System;

namespace Sale.CDBNames
{
	/// <summary>
	/// Summary description for CDBNames.
	/// </summary>
    public class DM_CATEGORY
    {
        public const string ID = "ID";
        public const string CATEGORY_CODE = "CATEGORY_CODE";
        public const string CATEGORY_NAME = "CATEGORY_NAME";
        public const string CATEGORY_PARENT_ID = "CATEGORY_PARENT_ID";
        public const string DISPLAY_ORDER = "DISPLAY_ORDER";
        public const string DISPLAY_LEVEL = "DISPLAY_LEVEL";
        public const string CATEGORY_DESCRIPTION = "CATEGORY_DESCRIPTION";
    }

    public class DM_PRODUCT
    {
        public const string ID = "ID";
        public const string PRODUCT_CODE = "PRODUCT_CODE";
        public const string PRODUCT_NAME = "PRODUCT_NAME";
        public const string UNIT_ID = "UNIT_ID";
        public const string CATEGORY_ID = "CATEGORY_ID";
        public const string IMAGE_PATH = "IMAGE_PATH";
        public const string DESCRIPTION = "DESCRIPTION";
        public const string PROVIDER_ID = "PROVIDER_ID";
        public const string CURRENT_PRICE = "CURRENT_PRICE";
    }

    public class DM_UNIT
    {
        public const string ID = "ID";
        public const string UNIT_CODE = "UNIT_CODE";
        public const string DESCRIPTION = "DESCRIPTION";
    }
    public class DM_PROVIDER
    {
        public const string ID = "ID";
        public const string PROVIDER_CODE = "PROVIDER_CODE";
        public const string PROVIDER_NAME = "PROVIDER_NAME";
        public const string MOBILE = "MOBILE";
        public const string EMAIL = "EMAIL";
        public const string ADDRESS = "ADDRESS";
        public const string TAX_CODE = "TAX_CODE";
    }

}



