using System;
using System.Collections.Generic;
using System.Text;

namespace hw20._06;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write your string");
        string word = Console.ReadLine();
        List<string> permutations = new List<string>();
        int[] factorials = new int[word.Length + 1];
        factorials[0] = 1;

        for (int i = 1; i <= word.Length; i++)
        {
            factorials[i] = factorials[i - 1] * i;
        }

        for (int i = 0; i < factorials[word.Length]; i++)
        {
            StringBuilder sb = new StringBuilder(word);

            string permutation = "";
            int temp = i;

            for (int j = word.Length; j > 0; j--)
            {
                int q = temp / factorials[j - 1];
                int r = temp % factorials[j - 1];

                permutation += sb[q];
                sb.Remove(q, 1);
                temp = r;
            }

            if (!permutations.Contains(permutation))
            {
                permutations.Add(permutation);
            }
        }
        Console.WriteLine("All permutations:");
        foreach (string perm in permutations)
        {
            Console.WriteLine(perm);
        }
    }
}
