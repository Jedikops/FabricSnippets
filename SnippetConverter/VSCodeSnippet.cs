using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetConverter
{
	public class VSCodeSnippet
	{
		public string prefix { get; set; }
		public string description { get; set; }
		public string[] body { get; set; }
	}

}
