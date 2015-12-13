using System;
using System.IO;
using System.Net;
using System.Text;
namespace phpsecurity
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string URI = "http://chillbot/security/";
			Console.WriteLine ("Security");
			string person = Console.ReadLine ();
			string myParameters = "name="+person;

			using (WebClient wc = new WebClient()) {
				wc.Headers [HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
				string HtmlResult = wc.UploadString (URI, myParameters);
				bool success = HtmlResult.Contains ("welcome");
				bool ohno = HtmlResult.Contains ("gtfo");
				if (success)
					Console.WriteLine ("Welcome");
				if (ohno) {
					Console.WriteLine ("you are not allowed");
				

				}
	
			}

		}

	}}
