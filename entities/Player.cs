using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace dodge_em_all;

public class Player : Entity {
    public Player(
        Vector2 position, 
        Texture2D texture, 
        Color color, 
        GraphicsDevice graphicsDevice, 
        float width, 
        float height, 
        float movementSpeed
    ) : base(position, texture, color, graphicsDevice, width, height, movementSpeed) {
        
    }

    public override void Update(GameTime gameTime) {
        float delta = (float)gameTime.ElapsedGameTime.TotalSeconds; 

        Vector2 movement = Vector2.Zero;

        if(InputManager.Instance.IsKeyHeld(Keys.W)) movement.Y -= 1;
        if(InputManager.Instance.IsKeyHeld(Keys.A)) movement.X -= 1;
        if(InputManager.Instance.IsKeyHeld(Keys.S)) movement.Y += 1;
        if(InputManager.Instance.IsKeyHeld(Keys.D)) movement.X += 1;

        if(movement != Vector2.Zero) movement.Normalize();

        this.Position += movement * this.MovementSpeed * delta;

        UpdateBounds();
    }

    public override void Draw(SpriteBatch batch) {
        batch.Draw(this.Texture, this.Bounds, this.Color);
    }
}