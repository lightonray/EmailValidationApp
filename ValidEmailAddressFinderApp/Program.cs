using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace EmailValidationApp

{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter your E-mail address: ");
			string email = Console.ReadLine();

			if (isValidEmail(email))
			{
				Console.WriteLine("Yes, that's a valid e-mail address");
			}
			else
			{
				Console.WriteLine("No, that's not a valid e-mail address");
			}
		}

		private static bool isValidEmail(string email)
		{
			try
			{
				MailAddress mail = new MailAddress(email);
				return true;
			}
			catch
			{
				return false;
			}
		}
	}

}
