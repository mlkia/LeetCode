// See https://aka.ms/new-console-template for more information

List <string> Output = new List <string> ();

IList<string> FizzBuzz(int n) 
{

	for (int i = 1; i <= n; i++)   // n
		{
			if (i % 3 == 0 && i % 5 == 0)
			   {
					Output.Add("FizzBuzz");
			   }
			else if (i % 3 == 0)
					{
						Output.Add("Fizz");
					}
			else if (i % 5 == 0)
					{
						Output.Add("Buzz");
					}
			else 
				{
					Output.Add(i.ToString());
				}
		}

		return (Output);
}


foreach (string item in FizzBuzz(15))
{
	Console.Write($"{item}, ");
}

Console.WriteLine ("----------------------------------------------------");
Console.WriteLine ("Big o (Time Complexity) of this is O(n)");	
Console.WriteLine ("----------------------------------------------------");

//Output:1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz