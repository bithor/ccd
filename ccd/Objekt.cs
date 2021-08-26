using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace ccd {

    public abstract class Objekt {

        public Vector2 Position;
        public Rectangle HitBox;
        public Tillstand Tillstand;
        public bool Kolliderar;
        public int HP;
        protected SpriteBatch SpriteBatch;
        protected SpelResurser SpelResurser;

        public Objekt(SpriteBatch spriteBatch, SpelResurser spelResurser) {
            SpriteBatch = spriteBatch;
            SpelResurser = spelResurser;
            Kolliderar = false;
        }
        public abstract void Rita();
        public abstract void Uppdatera(GameTime gameTime);
    }
}