string input = string.Empty;

while((input = Console.ReadLine()) != "END")
{
    Console.WriteLine(PalindromeCheck(input));
}

static bool PalindromeCheck(string number)
{
    string reversed = new string(number.Reverse().ToArray());
    bool result = (number == reversed);
    return result;
}