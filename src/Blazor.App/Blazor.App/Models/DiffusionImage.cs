namespace Blazor.App.Models
{
    public class DiffusionImage
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string ImagePath { get; set; }

        public DiffusionImage(int Width, int Height,string ImagePath)
        {
            this.Width = Width;
            this.Height = Height;
            this.ImagePath = ImagePath;
        }
    }
}
