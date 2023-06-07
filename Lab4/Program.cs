
// Lab4 Part 1. Finding max number in each list.

using System;
using System.Collections.Generic;
/* commented out due to conficliting main methods
public class Program
{

    // Create helper function to find largest number in a list using values as arg
    public static int largestInt(List<int> values)
    {
        // set maxNum to minimum value, and iterate through list to see if each 
        // value is greater than the current value of maxNum.
        int maxNum = int.MinValue;
        foreach (int value in values)
        {
            if (value > maxNum)
            {
                maxNum = value;
            }
        }
        return maxNum;
    }

    public static List<int> MaxNumbersInLists(List<List<int>> allLists)
    {
        List<int> listOfMaxNums = new List<int>();
        // Must use count instead of length for int lists
        for (int i = 0; i < allLists.Count; i++)
        {
            List<int> values = allLists[i];
            // set maxNum to helper function values, and add to listOfMaxNums
            int maxNum = largestInt(values);
            listOfMaxNums.Add(maxNum);
            Console.WriteLine($"List {i + 1} has a maximum of {maxNum}");
        }
        return (listOfMaxNums);
    }

    public static void Main(string[] args)
    {
        List<List<int>> allLists = new List<List<int>>
        {
            new List<int> { 1, 5, 3 },
            new List<int> { 9, 7, 3, -2 },
            new List<int> { 2, 1, 2 }
        };
        // Create new listOfMaxNums by using allLists as arg
        List<int> listOfMaxNums = MaxNumbersInLists(allLists);
        // Iterate over each list and display maxNum by calling maxNumberInLists and allLists as arg
        // giving the data and console writing line 32 for each list in allLists.
        foreach (int num in listOfMaxNums)
        {
            Console.WriteLine();
        }
    }
    

    // This code would be considered ON as there are no nested loops. This is because
    // I have written helper method such as largestInt and used them in other blocks
    // of code in the Program.

    // Part 2. Highest Grade.
    
    public class Program
    {
        public static string HighestGrade(List<List<int>> listOfCourses)
        {
        // set highest grade to min value of integer
            int highestGrade = int.MinValue;
            List<int> highestGradeClasses = new List<int>();

            for (int classIndex = 0; classIndex < listOfCourses.Count; classIndex++)
            {
                List<int> classGrades = listOfCourses[classIndex];

                foreach (int grade in classGrades)
                {
                    if (grade > highestGrade)
                    {
                    // iterate through class grades, if grade is greater than current
                    // highest grade, clear the list to place class indexes in with their
                    // appropriate number instead of 0, 1 ,2.
                        highestGrade = grade;
                        highestGradeClasses.Clear();
                        highestGradeClasses.Add(classIndex + 1);
                    }
                    // must add elseif in case we already have the highest number in that list.
                    else if (grade == highestGrade)
                    {
                        highestGradeClasses.Add(classIndex + 1);
                    }
                }
            }

            string classes = string.Join(", ", highestGradeClasses);
            return ($"The highest grade is {highestGrade}. This grade was found in class(es) {classes}.");
        }

        public static void Main(string[] args)
        {
            List<List<int>> listOfCourses = new List<List<int>>
    {
        new List<int> { 85, 92, 67, 94, 94 },
        new List<int> { 50, 60, 57, 95 },
        new List<int> { 95 }
    };
        // run list of courses through highest grade variable and set it to a new string,
        // then console.write it to recieve your final output
            string highestGradeMessage = HighestGrade(listOfCourses);
            Console.WriteLine(highestGradeMessage);
        }
    }
// is this code considered ON^2 as I have a foreach inside for loop, as well as
// if and else if loop inside my for loop?
*/

// Part 3. Sorted List
List<int> orderByLooping = new List<int> { 6, -2, 5, 3 };
// must use count instead of length for int lists *
for (int i = 0; i < orderByLooping.Count - 1; i++)
{
    for (int j = 0; j < orderByLooping.Count - 1 - i; j++)
    {
        if (orderByLooping[j] > orderByLooping[j + 1])
        {
            int newNumbers = orderByLooping[j];
            orderByLooping[j] = orderByLooping[j + 1];
            orderByLooping[j + 1] = newNumbers;
        }
    }
}

Console.WriteLine(string.Join(", ", orderByLooping));

// the complexity for the sorted list algorithm is ON^2 as there is a for loop inside a for loop
// Is this considered bubble sorting already? I am unsure how to refactor the solution.