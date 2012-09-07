using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using Geo.DataClasses;

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
			factory.CreateDataAdapter();
		}
		~DataBaseHelper()
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
		public List<GeoData> GetFullGeoList()
		{
			List<GeoData> geoDatas=new List<GeoData>();
			DbCommand command = connection.CreateCommand();
			command.CommandText = "Select * from Geo";
			DbDataReader result = command.ExecuteReader();
			while (result.Read())
			{
				geoDatas.Add(new GeoData(DbDataConvert.ToInt32(result["LicenseId"]),
										DbDataConvert.ToString(result["DnsName"]),
										DbDataConvert.ToString(result["Ip"]),
										DbDataConvert.ToString(result["City"]),
										DbDataConvert.ToString(result["Country"]),
										DbDataConvert.ToString(result["CountryCode"]),
										DbDataConvert.ToString(result["RegionCode"]),
										DbDataConvert.ToString(result["RegionName"]),
										DbDataConvert.ToString(result["PostalCode"]),
										DbDataConvert.ToDecimal(result["Latitude"]),
										DbDataConvert.ToDecimal(result["Longitude"])));
			}
			result.Close();
			return geoDatas;
		}


	}
}