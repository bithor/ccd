using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace ccd {

    public class KollisionsHanterare {

        public List<Rectangle> Colliders = new List<Rectangle>();
        public Rectangle SpelarHitBox;
        public bool Kolliderar;
        public KollisionsHanterare(){

        }
        public void KollisionsKoll() {

            foreach(Rectangle HitBox in Colliders) {
                Kolliderar = SpelarHitBox.Intersects(HitBox);
            }
        }
    }

}