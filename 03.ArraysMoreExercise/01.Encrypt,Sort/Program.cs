using System.Collections.Immutable;

int lines = int.Parse(Console.ReadLine());

string[] names = new string[lines];
for (int k = 0; k < lines; k++)
{
    names[k] = Console.ReadLine();
}
int[] encryption = new int[lines];

for (int i = 0; i < lines; i++)
{
    for (int j = 0; j < names[i].Length; j++)
    {
        char charToEncrypt = names[i][j];
        if (charToEncrypt == 'a' || charToEncrypt == 'e' || charToEncrypt == 'i' || charToEncrypt == 'o' || charToEncrypt == 'u' ||
            charToEncrypt == 'A' || charToEncrypt == 'E' || charToEncrypt == 'I' || charToEncrypt == 'O' || charToEncrypt == 'U')
        {
            encryption[i] += charToEncrypt * names[i].Length;
        }
        else
        {
            encryption[i] += charToEncrypt / names[i].Length;
        }
    }
}

Array.Sort(encryption);

foreach (int encryptedName in encryption)
{
    Console.WriteLine(encryptedName);
}