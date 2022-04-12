using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public partial class Program
	{
		[Serializable]
		public class TasksCollection
		{
			public static int tasksMaxCount = 20;
			public TasksCollection()
			{ }
			public List<Task> _tasks = new List<Task>();

			public void Add(Task task)
			{
				_tasks.Add(task);

			}

            public void Add(string theme, string question, string answ1, string answ2, string answ3, string answ4, int correct)
            {
                string[] answers = {answ1, answ2, answ3, answ4 };
                Task task = new Task(theme, question, answers, correct);
                _tasks.Add(task);
            }


			public int Count()
			{
				return _tasks.Count();
			}

			public void Run(User current)
			{
                foreach (Task task in _tasks)
                {
                  
                task.ShowQuestion();
                string userInput = Console.ReadLine();
                int answ;
                try
                {
                    answ = Convert.ToInt32(userInput);
                }
                catch
                {
                        Console.WriteLine("Cut the users hands.");
                }
                    
                  
                  
                }
			}

			

		}
	}
}
