public class Scripture {
    private Reference _reference = new Reference();
    public List<string> _words = new List<string>();
    public Scripture()
    {
        Reference reference = new Reference();
        _reference = reference;
        string words = "For God so love the world, that he gave his only begotten son. That whosoever believeth in him, should not perish, but have everlasting life.";
        List<string> wordsList = new List<string>(words.Split(" "));
        _words.AddRange(wordsList);
    }
    public Scripture(string words, string book, int chapter, int verse)
    {
        Reference reference = new Reference(book, chapter, verse);
        _reference = reference;
        List<string> wordsList = new List<string>(words.Split(" "));
        _words.AddRange(wordsList);
        
    }
    public Scripture(string words, string book, int chapter, int verse, int secondVerse)
    {
        Reference reference = new Reference(book, chapter, verse, secondVerse);
        _reference = reference;
        List<string> wordsList = new List<string>(words.Split(" "));
        _words.AddRange(wordsList);
    }
    public void HideWords()
    {
        
        Random random = new Random();
        
        string again = "again";
        while (again == "again")
        {
            int randomNumber = random.Next(_words.Count);
            Word singleWord = new Word(_words[randomNumber]);
            if (singleWord.IsHidden(_words[randomNumber]) != true)
            {
                string change = singleWord.Hide();
                _words[randomNumber] = change;
                again = "stop";
            }
        }
    }
    public string GetRenderedText()
    {
        return ($"{_reference.GetOneVerse()}{string.Join(" ",_words)}");
        
    } 
    public string GetRenderedTextTwoVerses()
    {
        return ($"{_reference.GetTwoVerses()}{string.Join(" ",_words)}");
        
    } 
    public bool IsCompletelyHidden()
    {
        int count = 0;
        foreach (string word in _words)
        {
            if (word == "___")
            {
                count += 1;
            }
        }
        int lenghtOfVerse = _words.Count();
        if (count == lenghtOfVerse)
        {
            return true;
        }
        else return false;
    }
}