using WindowsWallpaper.ImageProviders;

namespace WindowsWallpaper
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var provider = new ImageProvider_Pexels();
            var l = await provider.GetListImages();

            File.WriteAllText("E:/test.json", l[0]);


        }
    }
}