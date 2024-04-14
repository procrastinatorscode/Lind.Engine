using Lindengien.Input;
using Lindengine.Core;
using Lindengine.Scenes;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace Demo.Scenes;

public class SceneOne : Scene
{
    public SceneOne(string name) : base(name)
    {

    }

    protected override void OnLoad()
    {
    }

    protected override void OnRender(double elapsedSeconds)
    {
        GL.ClearColor(Color4.Aqua);
    }

    protected override void OnUnload()
    {
    }

    protected override void OnUpdate(double elapsedSeconds)
    {
        if (InputManager.IsKeyboardKeyPressed(Keys.D1))
        {
            Console.WriteLine($"this is a \"{Name}\" scene");
        }
        else if (InputManager.IsKeyboardKeyPressed(Keys.D2))
        {
            Lind.Engine.Scenes.Select("two");
        }
    }

    protected override void OnWindowResize(Vector2i size)
    {
    }
}
