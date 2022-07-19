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



foreach (string item in FizzBuzz(5))
{
	Console.WriteLine(item);
}

Console.WriteLine ("----------------------------------------------------");
Console.WriteLine ("Big o (Time Complexity) of this is O(n)");	
Console.WriteLine ("----------------------------------------------------");