
/* Nested for loop causing too many exponential iterations?
for (int i = 0; i < c.Length; i++)
{
    // must initialize j as j = i + 1 so we compare each character c[i] with all the other characters c[j] in the array c. 
    // if you say j = i + 1 you stop yourself from comparing the same character in the same array
    for (int j = i + 1; j < c.Length; j++)
    {
        if (c[i] == c[j])
        {
            Console.Write($"'{c[j]}'");
        }
    }
}
*/

// Part 1
using System.Text;

string originalString = "Programmatic Python";
string lowerString = originalString.ToLower();
char[] c = lowerString.ToCharArray();
StringBuilder sb = new StringBuilder();

// is this too complex?
for (int i = 0; i < c.Length; i++)
{
    for (int j = i + 1; j < c.Length; j++)
    { // to use stringBuilder, we must set toString, and check the index of the character before to compare characters
        if (c[i] == c[j] && sb.ToString().IndexOf(c[i]) == -1)
        {
            sb.Append(c[i]);
        }
    }
}

// Can't set sb to charArray right away, must set toString, then toChar
char[] duplicateChars = sb.ToString().ToCharArray();

Console.WriteLine(string.Join(", ", duplicateChars));


// part 2 (are we allowed to use Distinct? It seemed to be the best approach rather than for loops)
Console.WriteLine();
Console.WriteLine("Please enter a sentence to get unique words");
Console.WriteLine();
string sentence = Console.ReadLine();
PrintUniqueWords(sentence);

// Use void/static void when you dont want to use return. Can console.write instead.
static void PrintUniqueWords(string sentence)
{
    string[] words = sentence.ToLower().Split(' ');
    // using distinct, with method syntax https://dotnettutorials.net/lesson/linq-distinct-method/
    string[] uniqueWords = words.Distinct().ToArray();

    Console.Write(string.Join(", ", uniqueWords));
}

// part 3 

Console.WriteLine();
Console.WriteLine("Please enter a sentence to be reversed");
string forward = Console.ReadLine();
char[] charArray = forward.ToCharArray();
// .Reverse reverses the order of the elements in a one-dimensional Array or in a portion of the Array.
// https://learn.microsoft.com/en-us/dotnet/api/system.array.reverse?view=net-7.0
Array.Reverse(charArray);
Console.WriteLine();
Console.WriteLine($"Your String: {forward}");
Console.WriteLine();
Console.WriteLine($"Your String Backwards: {new string(charArray)}");
Console.WriteLine();

// part 4

Console.WriteLine("Please enter a sentence to find the longest word");
string tulips = Console.ReadLine();
string[] words = tulips.Split(' ');
string longestWord = "";
// Source code I loosely based example off of https://www.educative.io/answers/how-to-find-the-longest-word-in-a-string
// Changed loop to foreach and if to iterate through each word.
foreach (string word in words)
{
    string currentWord = word.Trim();

    if (currentWord.Length >= longestWord.Length)
    {
        longestWord = currentWord;
    }
}

Console.WriteLine(longestWord);

/*

    Strings are immutable, and will be erased and re entered if changed. If we want to append, add on or change our string, we must use
    StringBuilder. StringBuilder does not create a new object in the code's memory, but it creates more space in the data entry point to
    account for the string that has been changed. 

    StringBuilder is an object, and must be created and initialized. To call a string with StringBuilder, we must use toString(), as StringBuilder
    is not a string. By doing so, we can now use .Append, .AppendLine, .Insert, .Remove and .Replace. StringBuilder is mutable, making
    it friendly for Algorithms and changing code.

    https://www.tutorialsteacher.com/csharp/csharp-stringbuilder
 
*/