// See https://aka.ms/new-console-template for more information




int[][]array2D = new int [][]  // Array of Arrays C# OR Jagged Arrays  C#
{
	new int[] {1,2,3,4},
	new int[] {5,6,7,8},
	new int[] {9,10,11,12},
}; 


int wealth  = 0;
int richest = 0;

  int MaximumWealth(int [][] accounts) {
        
    for (int i = 0; i < accounts.Length; i++) // n
        {
	        for (int j = 0; j < accounts[0].Length; j++) // n
	            {
		            wealth  += accounts[i][j];
	            }

	             if (wealth  > richest)
	                {
		                richest = wealth ;
	                }

	                wealth = 0;
        }
        
        return richest;
    }

Console.WriteLine(MaximumWealth(array2D));

Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Big o (Time Complexity) of this is O(n^2)");
Console.WriteLine("-----------------------------------------------------");