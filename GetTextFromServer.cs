namespace WindowsWallpaper
{
    internal class GetTextFromServer
    {
        public static async Task<string> Get(string url)
        {
            using (var client = new HttpClient())
            {
                var res = await client.GetAsync(url);
                return await res.Content.ReadAsStringAsync();
            }
        }
    }
}
