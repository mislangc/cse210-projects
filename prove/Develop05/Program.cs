using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        int totalPoints = 0;
        int choice = 0;
        string fileName = "myFile.txt";
        List<Goals> goals = new List<Goals>();
        while (choice != 6)
        {
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Display Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            choice = number;
            if (choice == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string inputTwo = Console.ReadLine();
                int numberTwo = int.Parse(inputTwo);
                int choiceTwo = numberTwo;
                if (choiceTwo == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal("","",0,"");
                    simpleGoal.SetGoalName();
                    simpleGoal.SetGoalDescription();
                    simpleGoal.SetGoalPoints();
                    goals.Add(simpleGoal);  
                }
                else if (choiceTwo == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal("","",0,"");
                    eternalGoal.SetGoalName();
                    eternalGoal.SetGoalDescription();
                    eternalGoal.SetGoalPoints();
                    goals.Add(eternalGoal);
                }
                else if (choiceTwo == 3)
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal("","",0,"",0,0,0);
                    checklistGoal.SetGoalName();
                    checklistGoal.SetGoalDescription();
                    checklistGoal.SetGoalPoints();
                    checklistGoal.SetGoalHowManyTimes();
                    checklistGoal.SetGoalBonusPoints();
                    goals.Add(checklistGoal);
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("The goals are: ");
                int numberOfGoals = 1;
                foreach (Goals goal in goals)
                {
                    Console.WriteLine($"{numberOfGoals}. "+ goal.GetGoalDetails());
                    numberOfGoals++;
                }
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename you want to save as? ");
                fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine($"{totalPoints}");
                    foreach (Goals goal in goals)
                    {
                        if (goal is SimpleGoal)
                        {
                            outputFile.WriteLine($"Simple Goal,{goal.GetGoalName()},{goal.GetGoalDescription()},{goal.GetGoalPoints()},{goal.GetGoalFinished()}");
                        }
                        else if (goal is EternalGoal)
                        {
                            outputFile.WriteLine($"Eternal Goal,{goal.GetGoalName()},{goal.GetGoalDescription()},{goal.GetGoalPoints()},{goal.GetGoalFinished()}"); 
                        }
                        else if (goal is ChecklistGoal)
                        {
                            outputFile.WriteLine($"Checklist Goal,{goal.GetGoalName()},{goal.GetGoalDescription()},{goal.GetGoalPoints()},{goal.GetGoalFinished()},{goal.GetGoalHowManyTimesDone()},{goal.GetGoalHowManyTimes()},{goal.GetGoalBonusPoints()}");
                        }                    
                    }
                }
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename you want to load? ");
                fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                totalPoints = int.Parse(lines[0]);
                lines = lines.Skip(1).ToArray();
                foreach (string line in lines)
                {   
                    string[] parts = line.Split(",");
                    if (parts[0] == "Simple Goal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(parts[1],parts[2],int.Parse(parts[3]),parts[4]);
                        goals.Add(simpleGoal);
                    }
                    else if (parts[0] == "Eternal Goal")
                    {
                        EternalGoal eternalGoal = new EternalGoal(parts[1],parts[2],int.Parse(parts[3]),parts[4]);
                        goals.Add(eternalGoal);
                    }
                    else if (parts[0] == "Checklist Goal")
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal(parts[1],parts[2],int.Parse(parts[3]),parts[4],int.Parse(parts[5]),int.Parse(parts[6]),int.Parse(parts[7]));
                        goals.Add(checklistGoal);
                    }
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("The goals are: ");
                int numberOfGoals = 1;
                foreach (Goals goal in goals)
                {
                    Console.WriteLine($"{numberOfGoals}. "+ goal.GetGoalName());
                    numberOfGoals++;
                }
                Console.Write("Which goal did you accomplish? ");
                string goalListInput = Console.ReadLine();
                int indexChoice = int.Parse(goalListInput);
                Goals goalAccomplished = goals[indexChoice - 1];
                if (goalAccomplished is SimpleGoal)
                {
                    goalAccomplished.SetGoalFinished("X");
                    totalPoints += goalAccomplished.GetGoalPoints();
                }
                else if (goalAccomplished is EternalGoal)
                {
                    totalPoints += goalAccomplished.GetGoalPoints();
                }
                else if(goalAccomplished is ChecklistGoal)
                {
                    goalAccomplished.AddGoalHowManyTimesDone();
                    if (goalAccomplished.GetGoalHowManyTimesDone() < goalAccomplished.GetGoalHowManyTimes())
                    {
                        totalPoints += goalAccomplished.GetGoalPoints();
                    }
                    else if (goalAccomplished.GetGoalHowManyTimesDone() == goalAccomplished.GetGoalHowManyTimes())
                    {
                        totalPoints += goalAccomplished.GetGoalPoints();
                        totalPoints += goalAccomplished.GetGoalBonusPoints();
                        goalAccomplished.SetGoalFinished("X");
                    }
                }
            }
        }
    }
}