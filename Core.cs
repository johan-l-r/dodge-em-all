using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace dodge_em_all;

public class Core : Game {
    private Object obj;
    private GraphicsDeviceManager graphics;

    public Core() {
        this.graphics = new GraphicsDeviceManager(this);

        this.graphics.PreferredBackBufferWidth = Globals.WindowHeight;
        this.graphics.PreferredBackBufferHeight = Globals.WindowHeight;

        Content.RootDirectory = "Content";

        IsMouseVisible = true;
    }

    protected override void Initialize() {
        obj = new Object(new Vector2(100, 100), 10, 10);
        Console.WriteLine(obj.Position.X);
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
