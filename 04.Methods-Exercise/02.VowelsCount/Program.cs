
char[] input = Console.ReadLine().ToCharArray();

PrintsVowelsCount(input);

void PrintsVowelsCount(char[] input)
{
    int vowels = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == 65 || input[i] == 97 || input[i] == 69 || input[i] == 101 || input[i] == 73 
            || input[i] == 105 || input[i] == 79 || input[i] == 111 || input[i] == 85 || input[i] == 117)
        {
            vowels++;
        }
    }
    Console.WriteLine(vowels);
}