using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Geo.DataClasses
{
	public class GeoData
	{
		private int licenseId;
		private string dnsName;
		private string ip;
		private string city;
		private string country;
		private string countryCode;
		private string regionCode;
		private string regionName;
		private string postalCode;
		private decimal latitude;
		private decimal longitude;

		public GeoData(int tLicenseId, string tDnsName, string tIp, string tCity, string tCountry, string tCountryCode,
		               string tRegionCode, string tRegionName, string tPostalCode, decimal tLatitude, decimal tLongitude)
		{
			licenseId = tLicenseId;
			dnsName = tDnsName;
			ip = tIp;
			city = tCity;
			country = tCountry;
			countryCode = tCountryCode;
			regionCode = tRegionCode;
			regionName = tRegionName;
			postalCode = tPostalCode;
			latitude = tLatitude;
			longitude = tLongitude;
		}

		public int LicenseId
		{
			get { return licenseId; }
		}

		public string DnsName
		{
			get { return dnsName; }
		}

		public string Ip
		{
			get { return ip; }
		}

		public string City
		{
			get { return city; }
		}

		public string Country
		{
			get { return country; }
		}

		public string CountryCode
		{
			get { return countryCode; }
		}

		public string RegionCode
		{
			get { return regionCode; }
		}

		public string RegionName
		{
			get { return regionName; }
		}

		public string PostalCode
		{
			get { return postalCode; }
		}

		public string Location
		{
			get { return string.Format("{0}:{1}", latitude, longitude); }
		}

		public string JSPresentation()
		{
			return string.Format("{0};",Location);
		}
	}
}