using Microsoft.Xna.Framework;

namespace dodge_em_all;

public class Object {
    public float Width { get; protected set; }
    public float Height { get; protected set; }
    public Vector2 Position { get; protected set; }
    public Rectangle Bounds { get; set; }

    public Object(Vector2 position, float width, float height) {
        this.Width = width;
        this.Height = height;

        this.Position = position;

        UpdateBounds();
    }

    protected void UpdateBounds() {
        this.Bounds = new Rectangle(
            (int)this.Position.X,
            (int)this.Position.Y,
            (int)this.Width,
            (int)this.Height
        );
    }
}