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
		public class Task
		{
			public string _theme;
			public string _question;
			//public int _questionCount;
			public string[] _answers;
			public int _correct;


			public Task() { }

			public Task(string thm, string qstn, string[] answrs, /*int qCount,*/ int crct)
			{
				_theme = thm;
				_question = qstn;
				_answers = answrs;
				_correct = crct;

			}
			public void ShowQuestion()
			{
				Console.WriteLine(_theme);
				Console.WriteLine(_question);
				foreach (var item in _answers)
				{
					Console.WriteLine(item);
				}
			}
			
			public void AskAnswer()
			{
				Console.Read();
			}

		}
	}
}
