string[] names = { "Peter", "Michell", "Jane", "Steve" };
string[] places = { "Sofia", "Plovdiv", "Varna", "Bugars" };
string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
string[] details = { "near the river", "at home", "in the park" };

string GetRandomWord(string[] words)
{
    Random random = new Random();  
    int randomIndex = random.Next(words.Length);
    string word = words[randomIndex];
    return word;
}
Console.WriteLine("Hello, this is your first random-generated sentence: ");
while (true)
{
    string randomName = GetRandomWord(names);
    string randomPlaces = GetRandomWord(places);
    string randomVerbs = GetRandomWord(verbs);
    string randomNouns = GetRandomWord(nouns);
    string randomAdverbs = GetRandomWord(adverbs);
    string randomDetails = GetRandomWord(details);
    string who = $"{randomName} from {randomPlaces}";
    string action = $"{randomAdverbs} {randomVerbs} {randomNouns}";
    string sentence = $"{who} {action} {randomDetails}.";
    Console.WriteLine(sentence);
    Console.WriteLine("Click [Enter] to generate a new one.");
    Console.ReadKey();
}
