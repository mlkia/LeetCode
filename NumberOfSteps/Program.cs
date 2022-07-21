// See https://aka.ms/new-console-template for more information

//1342. Number of Steps to Reduce a Number to Zero
//https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/

int steps = 0;

int NumberOfSteps(int num) 
 {

	while (num > 0)
	{
		if (num % 2 == 0)
		{
			num = num / 2;
		}
		else 
		{
			num -=1;
		}

		steps +=1;
	}
	
	return steps;
 }

 Console.WriteLine(NumberOfSteps(14) + " steps");

Console.WriteLine ("----------------------------------------------------");
Console.WriteLine ("Big o (Time Complexity) of this is O(n)");	
Console.WriteLine ("----------------------------------------------------");

//Output: 6 steps

