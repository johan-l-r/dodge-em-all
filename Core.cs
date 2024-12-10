using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace dodge_em_all;

public class Core : Game {
    private GraphicsDeviceManager _graphics;

    public Core() {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";

        IsMouseVisible = true;
    }

    protected override void Initialize() {
        base.Initialize();
    }

    protected override void LoadContent() {

    }

    protected override void Update(GameTime gameTime) {
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime) {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        base.Draw(gameTime);
    }
}
