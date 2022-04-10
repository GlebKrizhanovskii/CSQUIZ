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
		public class UsersCollection 
		{
			public UsersCollection()
			{} 
			public List<User> _users = new List<User>();

			public void Add(string log, string pswd)
			{
				_users.Add(new User(log, pswd));
				
			}
			

			public int Count()
			{
				return _users.Count();
			}

			public void ShowAll()
			{
				foreach (var item in _users)
				{
					Console.WriteLine(item.info());
				}
			}
			public bool Find(User user)
			{
				foreach (var item in _users)
				{
					if ((item._log == user._log) && (item._pswd == user._pswd))
					{
						return true;
					}
					
				}

				return false;
			}
		}
	}
}
