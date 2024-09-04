namespace WindowsWallpaper.ImageProviders
{
    internal class ImageProvider_Unsplash : IImageProvider
    {
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
            var json = await GetTextFromServer.Get(urlBuilder.Url);
            return new List<string>() { json };
        }
    }
}
