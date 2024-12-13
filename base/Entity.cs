using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace dodge_em_all;

public abstract class Entity : Object, Drawable, Updatable {
    public float MovementSpeed { get; }
    public Texture2D Texture { get; }
    public Color Color { get; }

    public Entity (
        Vector2 position,
        Texture2D texture,
        Color color,
        GraphicsDevice graphicsDevice,
        float width, 
        float height,
        float movementSpeed
    ) : base(position, width, height) {
        this.MovementSpeed = movementSpeed;

        this.Color = color;
        
        this.Texture = this.Texture ?? (texture != null ? texture : new Texture2D(graphicsDevice, 1, 1));
        this.Texture.SetData<Color>(new Color[] { this.Color });
    }

    public abstract void Update(GameTime gameTime);

    public abstract void Draw(SpriteBatch batch);
}