using System;

public class Question02
{
	public Question02()
	{
	}

	public void CarpetingCost()
    {
		Console.WriteLine("____ Welcome to Carpeting Warehouse ___");
		Console.WriteLine("_______________________________________");


		Console.Write("What's the room's length?");
		double length = double.Parse(Console.ReadLine());

		Console.Write("What's the room's width?");
		double width = double.Parse(Console.ReadLine());

		Console.WriteLine("The Carpet Price is €6.50m²");
		
		//costing

		double carpetingCost = 6.50;
		double totalArea = length * width;
		double calculatePricing = totalArea * carpetingCost;
		Console.WriteLine("__________________________________");

		Console.WriteLine($"the total area in square meters are: {totalArea}");
		Console.WriteLine($"the Calculate pricing is: {calculatePricing}");

	}
}
