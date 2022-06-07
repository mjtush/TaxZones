using System;
using static System.Console;

namespace TaxZones
{
	class Program
	{
		private delegate double MyDeleageZone(double myPrice);

		static void Main()
		{
			string destinationZone;
			var zones = new[] { "ZONE1", "ZONE2", "ZONE3", "ZONE4" };
			MyDeleageZone zonePriceDelegate;

			WriteLine("Hello! This program will help you to callculate a shipment price of your item to our four zones.\n\rThose are our destinations:");

			foreach (var item in zones)
			{
				Write($"{item}\n");
			}

			while (true)
			{
				WriteLine("\nWhat is the destination zone? Type it in.");
				destinationZone = ReadLine().ToUpper();

				if (destinationZone is null)
				{
					throw new ArgumentNullException(nameof(destinationZone), "Destination zone cannot be null");
				}

				if (String.IsNullOrEmpty(destinationZone))
				{
					throw new ArgumentException("Please enter name of the zone", nameof(destinationZone));
				}

				if (destinationZone.ToUpper().Equals("EXIT"))
				{
					return;
				}

				WriteLine("What is the item price?");
				bool priceIsConverted = double.TryParse(ReadLine(), System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double itemPrice);

				if (!priceIsConverted)
				{
					throw new ArgumentException("Price evaluation failed. Enter price in valid format");
				}

				switch (destinationZone)
				{
					case "ZONE1":
						zonePriceDelegate = ShippingZones.Zone1Shippemt;
						WriteLine($"\nThe shipment price to the chosen destinantion is {zonePriceDelegate(itemPrice)}");
						break;
					case "ZONE2":
						zonePriceDelegate = ShippingZones.Zone1Shippemt;
						WriteLine($"\nThe shipment price to the chosen destinantion is {zonePriceDelegate(itemPrice)}");
						break;
					case "ZONE3":
						zonePriceDelegate = ShippingZones.Zone1Shippemt;
						WriteLine($"\nThe shipment price to the chosen destinantion is {zonePriceDelegate(itemPrice)}");
						break;
					case "ZONE4":
						zonePriceDelegate = ShippingZones.Zone1Shippemt;
						WriteLine($"\nThe shipment price to the chosen destinantion is {zonePriceDelegate(itemPrice)}");
						break;
				}
			}
		}
	}
}
