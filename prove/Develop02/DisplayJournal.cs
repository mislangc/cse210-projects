public class Display
{
    string _filename;

    public void DisplayJournal(string _filename)
        {
            string[] lines = System.IO.File.ReadAllLines(_filename);

            foreach  (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
}