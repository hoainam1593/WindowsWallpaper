namespace WindowsWallpaper
{
    internal class Downloader
    {
        public static async Task<string> DownloadText(string url)
        {
            using (var client = new HttpClient())
            {
                var res = await client.GetAsync(url);
                return await res.Content.ReadAsStringAsync();
            }
        }

        public static async Task DownloadImage(string url, string localFolder)
        {
            using (var client = new HttpClient())
            {
                var res = await client.GetAsync(url);

                var mediaType = res.Content.Headers.ContentType.MediaType;
                var mediaTypeSplitted = mediaType.Split('/');
                var extension = mediaTypeSplitted[1];
                var now = DateTime.Now;
                var filename = $"{now.Hour}-{now.Minute}-{now.Second}-{now.Millisecond} {now.Day}-{now.Month}-{now.Year}";
                var path = Path.Combine(localFolder, $"{filename}.{extension}");

                var bytes = await res.Content.ReadAsByteArrayAsync();
                await File.WriteAllBytesAsync(path, bytes);
            }
        }
    }
}
