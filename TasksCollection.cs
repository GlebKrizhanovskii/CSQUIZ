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


			public int Count()
			{
				return _tasks.Count();
			}

			public void Run()
			{
				foreach (var item in _tasks)
				{
					item.ShowQuestion();
					item.AskAnswer();
				}
			}

			

		}
	}
}
