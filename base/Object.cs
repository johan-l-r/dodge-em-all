using Microsoft.Xna.Framework;

namespace dodge_em_all;

public class Object {
    public float Width { get; set; }
    public float Height { get; protected set; }
    public Vector2 Position { get;  set; }

    public Object(Vector2 position, float width, float height) {
        this.Width = width;
        this.Height = height;
        this.Position = position;
    }
}