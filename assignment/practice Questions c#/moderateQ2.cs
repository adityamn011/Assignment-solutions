using System;

internal class ModerateQ2
{
    static void Main()
    {
        int n;

        Console.Write("enter num of elements in the array :\n");
        n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        for(int i=0; i<arr.Length; i++)
        {
            bool b = true;
            for(int j=0; j<i; j++)
            {
                if (arr[j] == arr[i])
                {
                    b=false; 
       
                }
            }
            if (b)
            {
                Console.Write(arr[i]+" ");
            }
            

        }
        
    }
}

