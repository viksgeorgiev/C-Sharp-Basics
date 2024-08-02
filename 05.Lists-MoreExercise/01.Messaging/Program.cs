

List<string> inputList = Console.ReadLine().Split(" ").ToList();

string inputString = Console.ReadLine();

List<string> strings = new List<string>();
List<string> result = new List<string>();

for (int i = 0; i < inputString.Length; i++)
{

    strings.Add(inputString[i].ToString());
}

int indexForGet = 0;

for (int i = 0;i < inputList.Count; i++)
{
    indexForGet = 0;
    foreach (char digit in inputList[i])
    {
        indexForGet += digit - '0';
    }

    indexForGet %= strings.Count;

    result.Add(strings[indexForGet]);
    strings.RemoveAt(indexForGet);
}

Console.WriteLine(String.Join("", result));