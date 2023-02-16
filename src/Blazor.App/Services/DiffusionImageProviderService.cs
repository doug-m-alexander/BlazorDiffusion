using Blazor.App.Models;

namespace Blazor.App.Services
{
  public class DiffusionImageProviderService
  {
    // Width Height Name
    private SortedList<int, DiffusionImage> defaultImages = new SortedList<int, DiffusionImage>
    {
      { 0, new DiffusionImage(512, 512, "default") },
      { 11, new DiffusionImage(512, 512, "legoMen") },
      { 2, new DiffusionImage(512, 512, "christianAlbum") },
      { 3, new DiffusionImage(512, 512, "rvivve") },
      { 14, new DiffusionImage(512, 512, "chessInThePark") },
      { 5, new DiffusionImage(512, 512, "evilGayAgenda") },
      { 6, new DiffusionImage(512, 512, "jqquiuilles") },
      { 7, new DiffusionImage(512, 512, "legoChessRainbow") },
      { 8, new DiffusionImage(512, 512, "manSandwich") },
      { 9, new DiffusionImage(512, 512, "mtgRickAstley") },
      { 10, new DiffusionImage(512, 512, "oatmealTerrorist") },
      { 1, new DiffusionImage(512, 512, "guggable") },
      { 12, new DiffusionImage(1024, 1024, "giantManBread") },
      { 13, new DiffusionImage(1280, 720, "wide") },
      { 4, new DiffusionImage(1280, 720, "gatsby") },
      { 15, new DiffusionImage(1280, 720, "planetGottfried") },
      { 16, new DiffusionImage(1280, 720, "beachSilhouettes") },
      { 17, new DiffusionImage(1280, 720, "youyoropear") },
      { 18, new DiffusionImage(1280, 720, "hobbit") },
    };

    public SortedList<int, DiffusionImage> GetDiffusionImages()
    {
      return defaultImages;
    }
  }
}
