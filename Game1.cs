using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogame_part_1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D textureDino,textureHoop, textureStar, textureEarth, textureBaller, textureLaser;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.Window.Title = "Dolphin safe, non gmo, organic, enviromentally friendly, Salad making simulator";

            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            textureEarth = Content.Load<Texture2D>("earth");
            textureStar = Content.Load<Texture2D>("star");
            textureLaser = Content.Load<Texture2D>("laser");
            textureHoop = Content.Load<Texture2D>("hoop");
            textureBaller = Content.Load<Texture2D>("iguodala");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightGoldenrodYellow);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(textureHoop, new Vector2(300,10), Color.White);
            _spriteBatch.Draw(textureBaller, new Vector2(10, 100), Color.White);
            _spriteBatch.Draw(textureStar, new Vector2(25, 400), Color.White);
            _spriteBatch.Draw(textureEarth, new Vector2(350, 430), Color.White);
            _spriteBatch.Draw(textureLaser, new Vector2(110, 430), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}