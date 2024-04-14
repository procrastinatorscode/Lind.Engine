﻿using Lindengine.Scenes;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace Lindengine.Core;

public class Lind
{
    private static readonly Lazy<Lind> Lazy = new(() => new Lind());
    public static Lind Engine => Lazy.Value;

    internal Window? Window;

    public SceneManager Scenes { get; } = new();

    private Lind() {}

    public void CreateWindow(Vector2i size, string title = "Lind.Engine", double updateFrequency = 60)
    {
        GameWindowSettings gameWindowSettings = new()
        {
            UpdateFrequency = updateFrequency
        };

        NativeWindowSettings nativeWindowSettings = new()
        {
            Title = title,
            ClientSize = size,
            Vsync = VSyncMode.On,
            WindowBorder = WindowBorder.Resizable,
            IsEventDriven = false,
            API = ContextAPI.OpenGL,
            APIVersion = new Version(4, 6),
            Profile = ContextProfile.Core,
            NumberOfSamples = 8
        };

        Window = new Window(gameWindowSettings, nativeWindowSettings);
    }

    public void ToggleFullscreen()
    {
        if (Window == null) return;

        Window.WindowState = Window.IsFullscreen
            ? WindowState.Normal
            : WindowState.Fullscreen;
    }

    public void Run()
    {
        Window?.Run();
    }

    public void Close()
    {
        Window?.Close();
    }
}
