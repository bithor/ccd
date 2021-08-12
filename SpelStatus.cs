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
        private KollisionsHanterare kollisionsHanterare;

        public SpelStatus(Game1 spel, ContentManager innehall) : base(spel, innehall) {
            CCD = spel;
            Innehall = innehall;
            SpriteBatch = spel._spriteBatch;
            SpelResurser = new SpelResurser(Innehall);
        }
        public override void EfterUppdatering(GameTime gameTime) {

        }

        public override void Initialisera() {
            spelare = new Spelare(SpriteBatch, SpelResurser);
            fiende = new Fiende(SpriteBatch, SpelResurser);
            kollisionsHanterare = new KollisionsHanterare();
            kollisionsHanterare.Colliders.Add(fiende.HitBox);
            spelare.Ladda();
        }

        public override void Rita(GameTime gameTime) {
            SpriteBatch.Begin(transformMatrix: Kamera.Transform);
            spelare.Rita();
            fiende.Rita();
            SpriteBatch.End();
        }

        public override void Uppdatera(GameTime gameTime) {
            spelare.Uppdatera(gameTime);
            Kamera.Follow(spelare.Position);
            kollisionsHanterare.SpelarHitBox = spelare.HitBox;
            kollisionsHanterare.KollisionsKoll();
            spelare.Kolliderar = kollisionsHanterare.Kolliderar;
            fiende.Uppdatera(gameTime);
            
        }
    }
}      