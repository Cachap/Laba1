using System;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

public static class MessageAnectod
{
	static string loadAnecdot(string answer)
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
		return (anectod[rnd.Next() % texts.Length]);
	}
	static string Anecdot()
	{
		WebClient wc = new WebClient();
		string url = "https://gwent.one/ru/debug/syndicate";
		string text = wc.DownloadString(url);
	}
}
