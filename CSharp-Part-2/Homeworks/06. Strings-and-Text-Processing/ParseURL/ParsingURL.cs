using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ParseURL
{
    class ParsingURL
    {
        static void Main()
        {
            var url = Console.ReadLine();
            const string pattern =
                @"\b(?<protocol>[a-zA-Z]*)://(?<server>[-a-zA-Z0-9.]+)(?<resource>/[-a-zA-Z0-9+&@#/%=~_!|:,.;]*)?";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(url);
            if (!match.Success)
            {
                throw new ArgumentOutOfRangeException("Invalid URL address!!!");
            }
            else
            {
                string protocol = match.Groups["protocol"].ToString();
                string server = match.Groups["server"].ToString();
                string resource = match.Groups["resource"].ToString();
                Console.WriteLine("[protocol] = {0}", protocol);
                Console.WriteLine("[server] = {0}", server);
                Console.WriteLine("[resource] = {0}", resource);
            }
        }
    }
}
