using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLexTools.Tools
{
    public class Snippet
    {
        public string ConvertCodeToVisualStudioCodeSnippet(string code)
        {
            var result = code;
            var result2 = result.Replace("\t", "");
            var result3 = result2.Replace("\n", "\",\nAAA");

            return result3;
        }
    }
}
