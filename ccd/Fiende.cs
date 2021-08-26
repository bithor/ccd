using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ccd {

    public class Fiende : Objekt {
        public Fiende(SpriteBatch spriteBatch, SpelResurser spelResurser) : base(spriteBatch, spelResurser) {
            SpriteBatch = spriteBatch;
            SpelResurser = spelResurser;
            Position = new Vector2(100, 100);
            HitBox = new Rectangle((int)Position.X, (int)Position.Y, SpelResurser.RandyAttackTextur.Width, SpelResurser.RandyAttackTextur.Height);
            HP = 100;

        }

        public override void Rita() {
            SpriteBatch.Draw(SpelResurser.RandyAttackTextur, Position, Color.White);
        }

        public override void Uppdatera(GameTime gameTime) {
        }
    }

}