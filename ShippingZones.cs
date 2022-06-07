using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxZones
{
	public static class ShippingZones
	{
		public static double Zone1Shippemt(double price) => price * 0.25;

		public static double Zone2Shippment(double price) => price * 0.12 + 25;

		public static double Zone3Shippment(double price) => price * 0.08;

		public static double Zone4Shippment(double price) => price * 0.04 + 25;

	}
}
