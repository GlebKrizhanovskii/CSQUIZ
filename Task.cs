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


			public Task() 
			{
				_theme = "testTheme";
				_question = "testQ";
				_answers = new string[4];
				_answers[0] = "a1";
				_answers[1] = "a2";
				_answers[2] = "a3CORRECT";
				_answers[3] = "a4";
				_correct = 3;
			}


			public Task(string thm, string qstn, string[] answrs, /*int qCount,*/ int crct)
			{
				_theme = thm;
				_question = qstn;
				_answers = answrs;
				_correct = crct;

			}
			public void ShowQuestion()
			{
				Console.WriteLine("\n"+ _theme);
				Console.WriteLine(_question);
				foreach (var item in _answers)
				{
					Console.WriteLine(item);
				}
                Console.WriteLine("\n");
			}
			
			//public void CheckAnswer(User current)                         //
			//{                                                             //
            //    int answ = 1;                                             //
            //    while (AnswerInputIsCorrect(answ))                        //
            //    {                                                         //
            //        answ = AskAnswer();                                   //
            //        if (AnswerIsCorrect(answ))                            //
            //        {                                                     // TODO: разобраться с этим
            //            current._score++;                                 //
            //            Console.WriteLine("Correct");                     //
            //            break;                                            //
            //        }                                                     //
            //        else                                                  //
            //        {                                                     //
            //            Console.WriteLine("Wrong");                       //
            //            break;                                            //
            //        }                                                     //
            //    }
			//}



            public bool AnswerIsCorrect(int answ)
			{
				if (answ == _correct) return true;
				else return false;
			}
            public bool AnswerInputIsCorrect(int answ)
			{
				if (answ >= 1 && answ <= 4)
					return true;
				else return false;
			}
            

		}
	}
}
