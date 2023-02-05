string[] names = { "Peter", "Michell", "Jane", "Steve", "Matt", "Michael", "John", "Martin", "Ivan", "Valq", "Aleksandra", "Nikoleta" };
string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas", "Ruse", "Veliko Turnovo", "Stara Zagora", "Qmbol", "Sozopol", "Botevgrad", "Blagoevgrad" };
string[] verbs = { "eats", "holds", "sees", "plays with", "brings", "sleeps", "decides", "expects", "collects" };
string[] nouns = { "stones", "cake", "apples", "laptop", "bikes", "pears", "headphones", "remote control", "PC", "cup" };
string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly", "carelessly", "bravely", "cheerfully", "rarely", "annualy" };
string[] details = { "near the river", "at home", "in the park", "at the airport", "in the bedroom", "near the school", "at the restaurant" };

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
    Console.WriteLine();
    Console.ReadKey();
}
