namespace WindowsWallpaper.ImageProviders
{
    internal class ImageProvider_Pexels : IImageProvider
    {
        string api_key = "h0mKpZTpyADQqjtaG1ye6bCak25fMHPmAn3iudsuWbk4IxAQAXcAaElQ";

        const string baseUrl = "https://api.pexels.com/v1";
        const string action = "curated";
        static Dictionary<string, string> param = new Dictionary<string, string>()
        {
            { "per_page", "80" },
        };

        public async Task<List<string>> GetListImages()
        {
            var urlBuilder = new UrlBuilder(baseUrl, action, param);
            var json = await Downloader.DownloadText(urlBuilder.Url);

            return new List<string>() { json };
        }
    }
}
