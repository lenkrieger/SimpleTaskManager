namespace SimpleTaskManager
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Task task1 = new Task(1, "End SimpleTaskManager", "debug, linter, end this project", DateTime.Today, true); //creating new task
            task1.DisplayTask(); // displaying created task
        }
    }
    public class Task
    {
        private int number;
        private string title;
        private string description; // bunch of variables
        private DateTime deadline;
        private bool IsCompleted;

        public Task(int number, string title, string description, DateTime deadline, bool isCompleted) // constructor
        {
            this.number = number;
            this.title = title;
            this.description = description;
            this.deadline = deadline;
            this.IsCompleted = isCompleted;
        }

        public void DisplayTask()
        {
            if (IsCompleted == true) // if task ended? change answer
            {
                Console.WriteLine("Task #" + number + " is Finished; Info: '" + title + "' ToDO '" + description + "' until " + deadline);
            }
            else
            {
                Console.WriteLine("Task #" + number + " is Unfinished; Info: '" + title + "' ToDO '" + description + "' until " + deadline);
            }
        }
    }
}