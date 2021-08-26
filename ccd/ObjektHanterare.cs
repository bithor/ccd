using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace ccd {

    public class ObjektHanterare {
        public List<Objekt> Objekt = new List<Objekt>();
        private KollisionsHanterare kollisionsHanterare;
        public ObjektHanterare(SpriteBatch spriteBatch){

        }

        public void Uppdatera(GameTime gameTime){
            kollisionsHanterare.KollisionsKoll(Objekt);
        }

        public void Rita() {
            for (int i = 0; i < Objekt.Count; i++){
                Objekt[i].Rita();
            }
        }

   }
}