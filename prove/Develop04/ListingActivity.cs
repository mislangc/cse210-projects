public class ListingActivity : Activity
{
    private List<string> _listingPrompt = new List<string>();
    private int _listedItems;
    public ListingActivity() : base()
    {
        _activity = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _listingPrompt.Add("Who are people that you appreciate?");
        _listingPrompt.Add("What are personal strengths of yours?");
        _listingPrompt.Add("Who are people that you have helped this week?");
        _listingPrompt.Add("When have you felt the Holy Ghost this month?");
        _listingPrompt.Add("Who are some of your personal heroes?");
    }
    public string GetListingIntroMessage()
    {
        return ($"List as many responses you can to the following prompt: ");
    }
    public string GetRandomListingPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_listingPrompt.Count);
        string randomPrompt = _listingPrompt[randomIndex];
        return ($"--- {randomPrompt} ---");
    }
    public string GetListedCountMessage(int listedItems)
    {
        _listedItems = listedItems;
        return ($"You listed {_listedItems} items!");

    }
}