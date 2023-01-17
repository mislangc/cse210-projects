public class Reference {
    private string _book;
    private int _chapter;
    private int _verse;
    private int _secondVerse;

    public Reference()
    {
        _book = "John";
        _chapter = 3;
        _verse = 16;
    }
    //One verse Constructor
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    //Two verses Constructor
    public Reference(string book, int chapter, int verse, int secondVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _secondVerse = secondVerse;
    }
    public string GetOneVerse()
    {
        return ($"{_book} {_chapter}:{_verse} ");
    }
    public string GetTwoVerses()
    {
        return ($"{_book} {_chapter}:{_verse}-{_secondVerse} ");
    }
}