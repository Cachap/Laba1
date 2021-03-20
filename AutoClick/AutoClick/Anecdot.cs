using System;
using System.Net;
using AngleSharp.Html.Parser;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AutoClick
{
	static class Anecdot
	{
		static string GetAnecdot(string answer)
		{
			if (answer == null)
			{
				return null;
			}
			var parser = new HtmlParser();
			Random rnd = new Random();
			string[] anectod;
			int count = 0;

			var texts = parser.ParseDocument(answer).GetElementsByClassName("tecst");
			anectod = new string[texts.Length];

			foreach (var text in texts)
			{
				foreach (var tmp in text.GetElementsByClassName("wrrating"))
				{
					tmp.Remove();
				}
				text.TextContent = text.TextContent.Replace("\n", "");
				anectod[count++] = text.TextContent;
			}
			 return anectod[rnd.Next() % texts.Length];
		}

		public  static string SearchAnecdot()
		{
			WebClient wc = new WebClient();
			string url = "https://anekdotbar.ru";
			string text = wc.DownloadString(url);
			return GetAnecdot(text);
		}
	}
}
