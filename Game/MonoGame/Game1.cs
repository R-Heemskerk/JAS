using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        dobbelstenen dices = new dobbelstenen();
        SpriteFont Arial;
        SpriteFont Dobbelstenentekst;

        int[] Worpen;
        Texture2D[] diceTextures = new Texture2D[6];

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            Worpen = dices.Worp();
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
            Arial = Content.Load<SpriteFont>("Arial");
            Dobbelstenentekst = Content.Load<SpriteFont>("Dobbelstenentekst");
            diceTextures[0] = Content.Load<Texture2D>("1");
            diceTextures[1] = Content.Load<Texture2D>("2");
            diceTextures[2] = Content.Load<Texture2D>("3");
            diceTextures[3] = Content.Load<Texture2D>("4");
            diceTextures[4] = Content.Load<Texture2D>("5");
            diceTextures[5] = Content.Load<Texture2D>("6");
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
            GraphicsDevice.Clear(Color.BurlyWood);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            spriteBatch.DrawString(Dobbelstenentekst, "Dobbelstenen" , new Vector2(250, 0), Color.Black);
            spriteBatch.DrawString(Dobbelstenentekst, "+", new Vector2(315, 125), Color.Black);
            spriteBatch.DrawString(Dobbelstenentekst, "=", new Vector2(470, 125), Color.Black);
            spriteBatch.Draw(diceTextures[Worpen[0] - 1], new Rectangle(200, 100, 100, 100), Color.White);
            spriteBatch.Draw(diceTextures[Worpen[1] - 1], new Rectangle(350, 100, 100, 100), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
