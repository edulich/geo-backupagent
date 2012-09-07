using System;
using System.Collections.Generic;
using Geo.DataClasses;
using Geo.Helper;

namespace Geo
{
	public partial class GeoMap : System.Web.UI.Page
	{
		private string servers=string.Empty;
		private List<GeoData> serverGeoData;
		protected void Page_Load(object sender, EventArgs e)
		{
			InitialiseServersLocations();
			serverLoc.Text = servers;
		}
		private void InitialiseServersLocations()
		{
			DataBaseHelper dataBase = DataBaseHelper.Instance;
			serverGeoData= dataBase.GetFullGeoList();
			foreach(GeoData data in serverGeoData)
			{
				servers += data.JSPresentation();
			}
			servers=servers.Substring(0, servers.Length - 1);

		}
	}
}