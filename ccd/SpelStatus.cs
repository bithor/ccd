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
        public Fiende fiende;
        public Fiende fiende2;
        public Fiende fiende3;
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

            
            fiende = new Fiende(200, 150);
            fiende2 = new Fiende(250, 150);
            fiende3 = new Fiende(300, 150);
            BasFiende fiende4 = new BasFiende(350, 150);

            spelare = new Spelare();

        }

        public override void Rita(GameTime gameTime) {

            SpriteBatch.Begin(transformMatrix: Kamera.Transform);
            SpriteSystem.Rita(SpriteBatch);
            AnimationsSystem.Rita(SpriteBatch);
            //objektHanterare.Rita();
            //hud.Rita();
            SpriteBatch.End();
        }

        public override void Uppdatera(GameTime gameTime) {
            SpriteSystem.Uppdatera(gameTime);
            AnimationsSystem.Uppdatera(gameTime);
            KolliderarSystem.KollisionsKoll(gameTime);
            KolliderarSystem.Uppdatera(gameTime);
            RorelseSystem.Uppdatera(gameTime);
            InputSystem.Uppdatera(gameTime);
            //hud.Uppdatera(gameTime, spelare.Inventory, spelare.Position);
            Transform KameraPos = spelare.GetKomponent<Transform>();
            Kamera.Follow(KameraPos.Position);
            //objektHanterare.Uppdatera(gameTime);
        }
    }
}      