using WindowsWallpaper.ImageProviders;

namespace WindowsWallpaper
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //var provider = new ImageProvider_Unsplash();

            //var l = await provider.GetListImages();

            //File.WriteAllText("E:/test.json", l[0]);

            var full = "https://images.unsplash.com/photo-1609342122563-a43ac8917a3a?crop=entropy\u0026cs=srgb\u0026fm=jpg\u0026ixid=M3w2NDgyNzR8MHwxfHJhbmRvbXx8fHx8fHx8fDE3MjQ5MjkyNzB8\u0026ixlib=rb-4.0.3\u0026q=85";

            var url = full;
            await Downloader.DownloadImage(url, "E:/test");
        }
    }
}