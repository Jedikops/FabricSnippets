using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SnippetConverter
{
	class Program
	{
		static void Main(string[] args)
		{
			const string SNIPPET_AUTHOR = "https://github.com/Sector43/FabricSnippets";
			const string SNIPPET_TYPE = "Expansion";
			const string SNIPPET_PATH = @"C:\Dev\Repos\FabricSnippets";

			string vscodeSnippetFilePath = Path.Combine(SNIPPET_PATH, @"VSCodeFabricSnippets.txt");

			Dictionary<string, VSCodeSnippet> snippets;

			using (StreamReader file = File.OpenText(vscodeSnippetFilePath))
			{
				snippets = JsonConvert.DeserializeObject<Dictionary<string, VSCodeSnippet>>(file.ReadToEnd());
			}

			foreach (KeyValuePair<string,VSCodeSnippet> snippet in snippets)
			{
				CodeSnippet cs = new CodeSnippet
				{
					Header = new CodeSnippetHeader
					{
						Title = snippet.Key,
						Author = SNIPPET_AUTHOR,
						Description = snippet.Value.description,
						Shortcut = snippet.Value.prefix,
						SnippetTypes = new CodeSnippetHeaderSnippetTypes[] { new CodeSnippetHeaderSnippetTypes { SnippetType = SNIPPET_TYPE } }
					}
				};

				StringBuilder sb = new StringBuilder();
				foreach (string bodyLine in snippet.Value.body)
				{
					sb.AppendLine(bodyLine);
				}


				cs.Snippet = new CodeSnippetSnippet
				{
					SnippetCode = new CodeSnippetSnippetCode
					{
						Language = "html",
						Code = sb.ToString()
					}
				};

				string vsSnippetFilename = String.Format("{0}.snippet", snippet.Value.prefix);
				string vsSnippetPath = Path.Combine(SNIPPET_PATH, vsSnippetFilename);
				XmlSerializer ser = new XmlSerializer(typeof(CodeSnippet));

				using (StreamWriter wtr = new StreamWriter(vsSnippetPath))
				{
					ser.Serialize(wtr, cs);
				}

			}
		}
	}
}
