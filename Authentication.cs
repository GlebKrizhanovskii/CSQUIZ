using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public partial class Program
	{
		class Authentication
		{
			public User dataInput()
			{
				string logInput, passInput;
				Console.WriteLine("Login: \n");
				logInput = Console.ReadLine();
				Console.WriteLine("Password: \n");
				passInput = Console.ReadLine();
				return new User(logInput, passInput);
			}

			
		}
	}
}
