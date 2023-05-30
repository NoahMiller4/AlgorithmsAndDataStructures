
// Lab1 created by Noah Miller

// Prompt user for integer n, which serves as array length of word list

int n = 0;

while (n <= 0)
{
    Console.WriteLine("Please enter a number");
    n = Int32.Parse(Console.ReadLine());
    Console.WriteLine("You have entered" + " " + n);
    Console.WriteLine();
}

string[] enteredWords = new string[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Please enter word {i + 1}");

    string newWords = Console.ReadLine();

    if (newWords.Length > 0 && !newWords.Contains(" "))
    {
        enteredWords[i] = newWords.ToLower();
    }
    else
    {
        Console.WriteLine("Sorry, but you must enter at least one character, with no spaces");
        i--;
    }
}
Console.WriteLine();

Console.WriteLine("The words you entered are:");
for (int i = 0; i < enteredWords.Length; i++)
{
    Console.WriteLine(enteredWords[i]);
}
Console.WriteLine();

// Initialize character as space so you are prompted to enter a character.
char charToCount = ' ';

while (!Char.IsLetter(charToCount))
{
    Console.WriteLine("Please enter a character");
    charToCount = Char.ToLower(Console.ReadKey().KeyChar);
    Console.WriteLine();
}
Console.WriteLine($"\nYou entered '{charToCount}'");

// get a count of how many times this character appears in all of the words
int charCount = 0;
int totalCount = 0;

foreach (string word in enteredWords)
{
    char[] chars = word.ToCharArray();

    foreach (char c in chars)
    {
        if (c == charToCount)
        {
            charCount++;
        }
        totalCount++;
    }
}

if ((charCount * 100) / totalCount > 25)
{
    Console.WriteLine($"The letter {charToCount} appears {charCount} times in the array. " +
        $"This letter makes up more than 25 % of the total number of characters.");
}
else
{
    Console.WriteLine($"The letter {charToCount} appears {charCount} times in the array.");
}
