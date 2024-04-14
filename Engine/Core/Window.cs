﻿using Lindengien.Input;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace Lindengine.Core;

internal class Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings)
    : GameWindow(gameWindowSettings, nativeWindowSettings)
{
    protected override void OnLoad()
    {
        GL.Enable(EnableCap.DepthTest);
        GL.Enable(EnableCap.CullFace);
        GL.Enable(EnableCap.Multisample);
        GL.Enable(EnableCap.Blend);

        GL.CullFace(CullFaceMode.Back);
        GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
        GL.ClearColor(Color4.Black);
    }

    protected override void OnResize(ResizeEventArgs e)
    {
        GL.Viewport(0, 0, e.Width, e.Height);

        Lind.Engine.Scenes.ResizeSelected(e.Size);
    }

    protected override void OnUpdateFrame(FrameEventArgs args)
    {
        if (InputManager.IsKeyboardKeyPressed(Keys.Escape))
        {
            Lind.Engine.Close();
        }

        Lind.Engine.Scenes.UpdateSelected(args.Time);
    }

    protected override void OnRenderFrame(FrameEventArgs args)
    {
        GL.Clear(ClearBufferMask.DepthBufferBit | ClearBufferMask.ColorBufferBit);

        Lind.Engine.Scenes.RenderSelected(args.Time);

        SwapBuffers();
    }

    protected override void OnUnload()
    {
        Lind.Engine.Scenes.UnloadSelected();
    }
}
