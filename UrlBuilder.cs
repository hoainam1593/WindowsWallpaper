using System.Text;

namespace WindowsWallpaper
{
    internal class UrlBuilder
    {
        public string Url { get; set; }

        public UrlBuilder(string baseUrl, string action, Dictionary<string,string> param)
        {
            var paramSB = new StringBuilder();
            var idx = 0;
            foreach (var i in param)
            {
                paramSB.Append($"{i.Key}={i.Value}");
                if (idx < param.Count - 1)
                {
                    paramSB.Append('&');
                }
                idx++;
            }
            Url = $"{baseUrl}/{action}?{paramSB}";
        }
    }
}
