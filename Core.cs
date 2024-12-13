using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace dodge_em_all;

public class Core : Game {
    private Player player;
    private GraphicsDeviceManager graphics;
    private SpriteBatch batch;

    public Core() {
        this.graphics = new GraphicsDeviceManager(this);

        this.graphics.PreferredBackBufferWidth = Globals.WindowHeight;
        this.graphics.PreferredBackBufferHeight = Globals.WindowHeight;

        Content.RootDirectory = "Content";

        IsMouseVisible = true;
    }

    protected override void Initialize() {
        this.player = new Player(new Vector2(100, 100), null, Color.Black, GraphicsDevice, 100, 100, 500);
        base.Initialize();
    }

    protected override void LoadContent() {
        this.batch = new SpriteBatch(GraphicsDevice);
    }

    protected override void Update(GameTime gameTime) {
        InputManager.Instance.Update();

        this.player.Update(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime) {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        this.batch.Begin();

        this.player.Draw(this.batch);

        this.batch.End();

        base.Draw(gameTime);
    }
}
