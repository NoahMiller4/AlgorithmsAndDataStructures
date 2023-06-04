// Part 1


// based off this link, is this too similar? 
//  https://www.javatpoint.com/program-to-print-the-duplicate-elements-of-an-array
/*
public class Duplicates
{
    public static void Main()
    {
        int[] arr = new int[] { 1, 2, 3, 4, 7, 9, 2, 4 }; 
        FindDuplicates(arr);
    }

    static void FindDuplicates(int[] arr)
    {
        Console.WriteLine("Duplicate elements: ");
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    Console.Write($"[ {arr[j]} ]");
                }
            }
        }
    }
}
*/


// Part 2
// Loosely based off of this link https://www.geeksforgeeks.org/merge-two-sorted-arrays/
// is this too messy? complex?
/*
public class MergedArrays
{
    public static void Main()
    {
        int[] arr1 = { 1, 2, 3, 4, 5 };
        int[] arr2 = { 2, 5, 7, 9, 13 };

        Console.WriteLine("Merged array:");
        MergeArrays(arr1, arr2);
    }

    static void MergeArrays(int[] arr1, int[] arr2)
    {
        int size1 = arr1.Length;
        int size2 = arr2.Length;
        int size3 = size1 + size2;

        int[] merge = new int[size3];

        int i = 0;
        int j = 0;
        int k = 0;

        while (i < size1 && j < size2)
        {
            if (arr1[i] <= arr2[j])
            {
                merge[k++] = arr1[i++];
            }
            else
            {
                merge[k++] = arr2[j++];
            }
        }

        while (i < size1)
        {
            merge[k++] = arr1[i++];
        }

        while (j < size2)
        {
            merge[k++] = arr2[j++];
        }

        for (int index = 0; index < size3; index++)
        {
            Console.Write(merge[index] + " ");
        }
    }
}
*/

// loosely based off this link https://www.geeksforgeeks.org/write-a-program-to-reverse-digits-of-a-number/
// recursive way but simplified? Mod 10 will give the remainder when a number will be divided by 10.
// https://www.quora.com/What-is-MOD-10-in-maths
public class Reversed
{
    public static void Main()
    {
        int num = 3415;
        int reversed = 0;

        while (num != 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num = num / 10;
        }

        Console.WriteLine("Reversed integer is: " + reversed);
    }
}

/*
  As stated in the geeksforgeeks link I provided, the complexity is Ologn, which is slower
  complexity that On https://stackoverflow.com/questions/10369563/difference-between-on-and-ologn-which-is-better-and-what-exactly-is-olo
*/