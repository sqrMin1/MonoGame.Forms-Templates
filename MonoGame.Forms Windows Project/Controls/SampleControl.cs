using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Forms.Controls;

namespace MonoGame.Forms_Windows_Project.Controls
{
    public class SampleControl : MonoGameControl
    {
        private readonly string WelcomeMessage = "Welcome to MonoGame.Forms!";
        private Texture2D Logo;

        protected override void Initialize()
        {
            base.Initialize();

            Logo = Editor.Content.Load<Texture2D>(@"Logo_Shadow_256");
            Editor.BackgroundColor = new Color(20, 19, 40);
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw()
        {
            base.Draw();

            Editor.spriteBatch.Begin();

            Editor.spriteBatch.Draw(Logo, new Vector2(
                       Editor.graphics.Viewport.Width / 2,
                       Editor.graphics.Viewport.Height / 2), 
                       null, Color.White, 0f, new Vector2(Logo.Width / 2, Logo.Height / 2), 1f, SpriteEffects.None, 0f);

            Editor.spriteBatch.DrawString(Editor.Font, WelcomeMessage, new Vector2(
                (Editor.graphics.Viewport.Width / 2) - (Editor.Font.MeasureString(WelcomeMessage).X / 2),
                (Editor.graphics.Viewport.Height / 2) - (Editor.FontHeight / 2) + Logo.Height / 2 + 10),
                Color.White);

            Editor.spriteBatch.End();

            Editor.DrawDisplay();
        }
    }
}
