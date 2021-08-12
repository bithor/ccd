using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace ccd {

    public abstract class Objekt {

        protected Vector2 Position;
        protected Rectangle HitBox;
        protected SpriteBatch SpriteBatch;
        protected SpelResurser SpelResurser;

        public Objekt(SpriteBatch spriteBatch, SpelResurser spelResurser) {
            SpriteBatch = spriteBatch;
            SpelResurser = spelResurser;
        }
        public abstract void Rita();
        public abstract void Uppdatera(GameTime gameTime);
    }
}