using System;

namespace LoggerExample
{
    public class Starter
    {
        private readonly Actions actions;

        public Starter()
        {
            actions = new Actions();
        }

        public void Run()
        {
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int randomNumber = random.Next(1, 4);

                switch (randomNumber)
                {
                    case 1:
                        actions.Start();
                        break;
                    case 2:
                        actions.SkipLogic();
                        break;
                    case 3:
                        Result result = actions.BreakLogic();
                        if (!result.Status)
                        {
                            Console.WriteLine($"Error occurred: {result.ErrorMessage}");
                        }
                        break;
                    default:
                        break;
                }
            }

            string allLogs = Logger.Instance.GetAllLogs();
            System.IO.File.WriteAllText("log.txt", allLogs);
        }
    }
}