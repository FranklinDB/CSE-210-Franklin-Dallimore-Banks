class Scripture
{
    private List<Word> _words;

    public Scripture (string bookName, int chapter, int verse, string test)
    {

    }
    public Scripture (string bookName, int chapter, int startVerse, int endVerse, string test)
        {
    
        }
    public void ShowScripture()
    {
        foreach(Word word in _words)
        {
            word.Display();
        }
    }

    private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = text.Split(' ');
        foreach(string w in tempWords)
        {
            Console.WriteLine(w);
        }
        return tempWordList;
        
    }

}