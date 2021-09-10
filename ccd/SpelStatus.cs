using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace ccd {

    public class SpelStatus : Status
    {
        private Game1 CCD;          
        private ContentManager Innehall;
        private readonly SpelResurser SpelResurser;
        public SpelStatus(Game1 spel, ContentManager innehall) : base(spel, innehall) {
            CCD = spel;
            Innehall = innehall;
            SpriteBatch = spel._spriteBatch;
            SpelResurser = new SpelResurser(Innehall);
        }
        public override void EfterUppdatering(GameTime gameTime) {

        }

        public override void LoadContent(){
        }

        public override void Initialisera() {

        }

        public override void Rita(GameTime gameTime) {

            SpriteBatch.Begin();

            SpriteBatch.End();
        }

        public override void Uppdatera(GameTime gameTime) {

        }
    }
}      