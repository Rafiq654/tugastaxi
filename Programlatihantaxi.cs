﻿using System;
namespace LatihanClassDanObject
{
	class Program
	{
		static void Main(string[] args)
		{
			// membuat objek dari class taxi

			Taxi taxi = new Taxi();


			// mengeset nilai properties objek saya dan kamu
			taxi.DriverName = "Rafiq";
			taxi.OnDuty = true;
			taxi.NumPassenger = 25;

			// memanggil method registrasi dan isi krs
			taxi.TaxiInfo();
			taxi.PickupPassenger();
			taxi.DropOffPassenger();

			Console.ReadKey();
		}

	}
}