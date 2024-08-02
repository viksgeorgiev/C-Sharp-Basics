
int numberOfMessages = int.Parse(Console.ReadLine());


FakeMessage fakeMessage = new FakeMessage();

string[] phrases = fakeMessage.Phrases;
string[] events = fakeMessage.Events;
string[] authors = fakeMessage.Authors;
string[] cities = fakeMessage.Cities;


Random random = new Random();

for (int i = 0; i < numberOfMessages; i++)
{
    Console.WriteLine($"{GetRandomElement(phrases)} {GetRandomElement(events)} {GetRandomElement(authors)} – {GetRandomElement(cities)}.");
}



string GetRandomElement(string[] array)
{
    int index = random.Next(0, array.Length);

    return array[index];
}


public class FakeMessage
{
    public string[] Phrases = {
        "Excellent product.",
        "Such a great product.",
        "I always use that product.",
        "Best product of its category.",
        "Exceptional product.",
        "I can't live without this product." };
    public string[] Events = {
        "Now I feel good.",
        "I have succeeded with this product.",
        "Makes miracles. I am happy of the results!",
        "I cannot believe but now I feel awesome.",
        "Try it yourself, I am very satisfied.",
        "I feel great!" };
    public string[] Authors = {
        "Diana",
        "Petya",
        "Stella",
        "Elena",
        "Katya",
        "Iva",
        "Annie",
        "Eva" };
    public string[] Cities = {
        "Burgas",
        "Sofia",
        "Plovdiv",
        "Varna",
        "Ruse" };
}




