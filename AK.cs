string sentence;

Console.WriteLine("Input a sentence: ");
sentence = Console.ReadLine();

int words = sentenceWords(sentence);

Console.WriteLine("Your sentence has " + words + " words");

static int sentenceWords(string sentence)
{
    string[] words = sentence.Split(' ');
    int wordCount = words.Length;
    return wordCount;
}

Console.ReadKey();