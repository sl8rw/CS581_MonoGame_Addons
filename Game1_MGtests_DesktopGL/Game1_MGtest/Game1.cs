using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
//taken from http://community.monogame.net/t/writing-your-own-2d-pixel-shader-in-monogame-for-absolute-beginners/10883
namespace Game1_MGtest
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D texture;
        Effect effect;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsFixedTimeStep = true;
            MaxElapsedTime = TimeSpan.FromMilliseconds(2000);
            TargetElapsedTime = TimeSpan.FromMilliseconds(20); // 20 milliseconds, or 50 FPS.





        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            texture = Content.Load<Texture2D>("graphics/4jA0ZsP");
            effect = Content.Load<Effect>("testeffect");


            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            FPSCounter.Render(GraphicsDevice);
            FPSCounter.Tick(0);
            FPSCounter.Render(GraphicsDevice, 0);
            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
            effect.Parameters["DayColor"].SetValue(50);

            //effect.CurrentTechnique = effect.Techniques["dnsjfknjns"];

            effect.CurrentTechnique.Passes[0].Apply();
            spriteBatch.Draw(texture, new Vector2(0, 0), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
