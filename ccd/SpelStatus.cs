using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace ccd {

    public class SpelStatus : Status
    {
        private Game1 CCD;          
        private ContentManager Innehall;
        private readonly SpelResurser SpelResurser;
        public static Spelare spelare;
        private Fiende fiende;
        private HUD hud;
        private ObjektHanterare objektHanterare;



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

            spelare = new Spelare();

        }

        public override void Rita(GameTime gameTime) {

            SpriteBatch.Begin();
            SpriteSystem.Rita(SpriteBatch);
            //SpriteBatch.Begin(transformMatrix: Kamera.Transform);
            //objektHanterare.Rita();
            //hud.Rita();
            SpriteBatch.End();
        }

        public override void Uppdatera(GameTime gameTime) {
            SpriteSystem.Uppdatera(gameTime);
            KolliderarSystem.Uppdatera(gameTime);
            RorelseSystem.Uppdatera(gameTime);
            InputSystem.Uppdatera(gameTime);
            //hud.Uppdatera(gameTime, spelare.Inventory, spelare.Position);
            //Kamera.Follow(spelare.sprite.Position);
            //objektHanterare.Uppdatera(gameTime);
        }
    }
}      