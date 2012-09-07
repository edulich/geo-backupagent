using System;

namespace Geo.Helper
{
	public static class DbDataConvert
	{
		public static string ToString(object value)
		{
			return !Convert.IsDBNull(value) ? value.ToString() : string.Empty;
		}

		public static bool ToBoolean(object value)
		{
			return !Convert.IsDBNull(value) ? Convert.ToBoolean(value) : false;
		}

		public static int ToInt32(object value, int defaultValue = default(int))
		{
			return !Convert.IsDBNull(value) ? Convert.ToInt32(value) : defaultValue;
		}

		public static double ToDouble(object value)
		{
			return !Convert.IsDBNull(value) ? Convert.ToDouble(value) : default(double);
		}

		public static decimal ToDecimal(object value)
		{
			return !Convert.IsDBNull(value) ? Convert.ToDecimal(value) : default(decimal);
		}

		public static long ToInt64(object value)
		{
			return !Convert.IsDBNull(value) ? Convert.ToInt64(value) : default(long);
		}

		public static DateTime ToDateTime(object value)
		{
			return !Convert.IsDBNull(value) ? (DateTime)value : DateTime.MinValue;
		}
	}
}