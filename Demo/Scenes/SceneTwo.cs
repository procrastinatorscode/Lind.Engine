using Lindengien.Input;
using Lindengine.Core;
using Lindengine.Scenes;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace Demo.Scenes;

public class SceneTwo : Scene
{
    public SceneTwo(string name) : base(name)
    {

    }

    protected override void OnLoad()
    {
    }

    protected override void OnRender(double elapsedSeconds)
    {
        GL.ClearColor(Color4.YellowGreen);
    }

    protected override void OnUnload()
    {
    }

    protected override void OnUpdate(double elapsedSeconds)
    {
        if (InputManager.IsKeyboardKeyPressed(Keys.D2))
        {
            Console.WriteLine($"this is a \"{Name}\" scene");
        }
        else if (InputManager.IsKeyboardKeyPressed(Keys.D1))
        {
            Lind.Engine.Scenes.Select("one");
        }
    }

    protected override void OnWindowResize(Vector2i size)
    {
    }
}
