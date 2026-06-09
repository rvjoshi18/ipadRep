using static System.Console;


Write("Enter a sentence: ");
string sentence = ReadLine();
string[] words = sentence.Split(' ');
WriteLine("\nWords in the sentence:");
for (int i = 0; i < words.Length; i++)
{
  WriteLine($"{i + 1}. {words[i]}");
}

