using Lindengine.Core;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace Lindengien.Input;

public static class InputManager
{
    public static bool IsKeyboardKeyPressed(Keys key)
    {
        return Lind.Engine.Window?.IsKeyPressed(key) ?? false;
    }
}
