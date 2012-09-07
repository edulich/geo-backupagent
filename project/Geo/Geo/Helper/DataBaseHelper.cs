using System.Configuration;
using System.Data.Common;

namespace Geo.Helper
{
	public class DataBaseHelper
	{
		private static DataBaseHelper instance;
		private DbConnection connection;
		//private static  
		private DataBaseHelper()
		{
			DbProviderFactory factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["ConnectionString"].ProviderName);
			connection = factory.CreateConnection();
			connection.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
			connection.Open();
		}
		public ~DataBaseHelper()
		{
			connection.Close();
		}
		public static DataBaseHelper Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new DataBaseHelper();
				}
				return instance;
			}
		}


	}
}