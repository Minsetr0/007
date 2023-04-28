string text = "Int String Char Bool";
string[] words = text.Split(' ');
foreach (string word in words)
{
    Console.WriteLine(word);
}
