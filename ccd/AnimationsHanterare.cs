using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ccd {
    public class AnimationsHanterare {

        public Animation[] Animationer;
        private int ValdAnimation;
        private Tillstand Tillstand;
        private Facing Facing;

        public AnimationsHanterare(SpelResurser spelResurser){
            Animationer = new Animation[2];
            Animationer[0] = new Animation(spelResurser.DougIdle, 2, 1f);
            Animationer[1] = new Animation(spelResurser.DougPromenad, 6, 10f);
        }
        public void Rita(SpriteBatch spriteBatch, Vector2 position) {
            Animationer[ValdAnimation].Rita(spriteBatch, position, Facing);
        }

        public void Uppdatera(GameTime gameTime, Tillstand tillstand, Facing facing) {
            ValdAnimation = (int)tillstand;
            Facing = facing;
            Animationer[ValdAnimation].Uppdatera(gameTime);
        }

    }
}