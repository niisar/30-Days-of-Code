using System;

class Solution
{
    static void Main(String[] args)
    {
        Console.ReadLine();

        var str = Console.ReadLine();
        var arr = str.Split(' ');

        for (int i = 0; i < n / 2; i++)
        {
            int tmp = arr[i];
            arr[i] = arr[n - i - 1];
            arr[n - i - 1] = tmp;
        }
        foreach(var a in arr){
            Console.Write(a+ " ");
        }
    }
}
