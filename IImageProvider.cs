namespace WindowsWallpaper
{
    internal interface IImageProvider
    {
        Task<List<string>> GetListImages();
    }
}
