public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _reflectQuestions = new List<string>();

    public ReflectingActivity() : base()
    {
        _activity = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _reflectQuestions.Add("Why was this experience meaningful to you?");
        _reflectQuestions.Add("Have you ever done anything like this before?");
        _reflectQuestions.Add("How did you get started?");
        _reflectQuestions.Add("How did you feel when it was complete?");
        _reflectQuestions.Add("What made this time different than other times when you were not as successful?");
        _reflectQuestions.Add("What was your favorite thing about this experience?");
        _reflectQuestions.Add("What could you learn from this experience that applies to other situations?");
        _reflectQuestions.Add("What did you learn about yourself through this experience?");
        _reflectQuestions.Add("How can you keep this experience in mind in the future?");
    }
    public string GetConsiderMessage()
    {
        return ($"Consider the following prompt: ");
    }
    public string GetInMindMessage()
    {
        return ($"When you have something in mind, press enter to continue.");
    }
    public string GetPonderMessage()
    {
        return ($"Now ponder on each of the following questions as they are related to this experience.");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        return ($"--- {randomPrompt} ---");
    }
    public string GetRandomReflectQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_reflectQuestions.Count);
        string randomReflectQuestion = _reflectQuestions[randomIndex];
        return ($"> {randomReflectQuestion}");
    }
}