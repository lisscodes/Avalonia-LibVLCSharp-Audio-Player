using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace App.Models;

public class Player
{
    public ImageBrush Image { get; }

    public Player(Bitmap? bitmap1)
    {
        Image = new ImageBrush(bitmap1);
    }
}
