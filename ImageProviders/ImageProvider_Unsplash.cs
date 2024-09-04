using Newtonsoft.Json;

namespace WindowsWallpaper.ImageProviders
{
    internal class ImageProvider_Unsplash : IImageProvider
    {
        internal class Jobject
        {
            internal class Url
            {
                public string full;
            }

            public Url urls;
        }

        const string baseUrl = "https://api.unsplash.com";
        const string action = "photos/random";
        static Dictionary<string, string> param = new Dictionary<string, string>()
        {
            { "client_id", "pq2HgWvmXXUoXrVGaGj7Riyuqg2RhGwcB0aQ6i6X2yQ" },
            { "orientation", "landscape" },
            { "query", "wallpaper" },
            { "count", "30" }
        };

        public async Task<List<string>> GetListImages()
        {
            var urlBuilder = new UrlBuilder(baseUrl, action, param);
            var json = await Downloader.DownloadText(urlBuilder.Url);
            return ParseJson(json);
        }

        public List<string> ParseJson(string json)
        {
            var lJobject = JsonConvert.DeserializeObject<List<Jobject>>(json);
            var result = new List<string>();
            foreach (var i in lJobject)
            {
                result.Add(i.urls.full);
            }
            return result;
        }
    }
}
