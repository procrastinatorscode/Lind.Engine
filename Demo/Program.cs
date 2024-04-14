using Demo.Scenes;
using Lindengine.Core;
using OpenTK.Mathematics;

Vector2i windowSize = new(1024, 768);
Lind.Engine.CreateWindow(windowSize, "Lind.Engine Demo", 144);
Lind.Engine.Scenes.Add(new SceneOne("one"));
Lind.Engine.Scenes.Add(new SceneTwo("two"));
Lind.Engine.Scenes.Select("one");
Lind.Engine.Run();