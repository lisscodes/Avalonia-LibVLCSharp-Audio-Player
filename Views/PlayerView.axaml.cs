using System;
using App.Models;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using LibVLCSharp.Shared;

namespace App.Views;

public partial class PlayerView : UserControl
{
    private Player? Player { get; set; }
    private SoundFx? SoundFx { get; set; }
    private double Velocity => 50;
    private double MarginX { get; set; }
    private double MarginY { get; set; }

    public PlayerView()
    {
        InitializeComponent();
        BuildPlayer();
        BuildSoundFx();
    }

    private void BuildPlayer()
    {
        Bitmap bitmap = new Bitmap(
            AssetLoader.Open(new Uri("avares://App/Assets/cat.png"))
        );
        Player = new Player(bitmap);
    }

    private void BuildSoundFx()
    {
        SoundFx = new SoundFx("Assets/audio.mp3");
    }

    public void Rect_OnKeyDown(object? sender, KeyEventArgs e)
    {
        if (SoundFx?.State == VLCState.Playing)
        {
            return;
        }

        SoundFx?.Stop();

        switch (e.Key)
        {
            case Key.W or Key.Up:
                MarginY -= Velocity;
                SoundFx?.Play();
                break;
            case Key.S or Key.Down:
                MarginY += Velocity;
                SoundFx?.Play();
                break;
            case Key.A or Key.Left:
                MarginX -= Velocity;
                SoundFx?.Play();
                break;
            case Key.D or Key.Right:
                MarginX += Velocity;
                SoundFx?.Play();
                break;
        }
        Rect.Margin = new Thickness(MarginX, MarginY, 0, 0);
    }

    public void Rect_RequestFocus(object? sender, RoutedEventArgs e)
    {
        Rect.Fill = Player?.Image;
        Rect.Focus();
    }
}