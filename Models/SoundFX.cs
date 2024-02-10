using LibVLCSharp.Shared;

namespace App.Models;

public class SoundFx : LibVLC
{
    private string File { get; }
    private Media Media { get; }
    private MediaPlayer MediaPlayer { get; }
    
    public SoundFx(string file)
    {
        File = file;
        Media = new Media(this, File);
        MediaPlayer = new MediaPlayer(Media);
        Log += null;
    }
    
    public void Play() => MediaPlayer.Play();
    
    public void Stop() => MediaPlayer.Stop();
    
    public VLCState State => MediaPlayer.State;
}