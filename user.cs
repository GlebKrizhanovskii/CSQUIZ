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
		public class User
		{
			public string _log;
			public string _pswd;
			public int _score;
			public User() { }

			public User(string log, string pswd)
			{
				_log = log;
				_pswd = pswd;
			}
			
			public string info()
			{
				return ("Login: " + _log + " Password: " + _pswd + " Score:" + _score);
			}
		}


	}
}
