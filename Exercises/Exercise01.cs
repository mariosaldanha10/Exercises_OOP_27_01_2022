using System;

public class Question01
{
	//constructor
	public Question01()
	{
		
		
	}

	public void simpleCalculator()
    {
        Console.WriteLine("Please enter first value: ");
        int firstValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second value: ");
        int secondValue = int.Parse(Console.ReadLine());

        int resultSum = firstValue + secondValue;
        int resultNeg = firstValue - secondValue;
        int resultMul = firstValue * secondValue;
        int resultDiv = firstValue / secondValue;
        int resultRem = firstValue % secondValue;

        Console.WriteLine("Summation: {0}\nSubtraction: {1}\nMultiplication : {2}\nDivision : {3}\nRemainder : {4}"
            , resultSum, resultNeg, resultMul, resultDiv, resultRem);
    }
}
