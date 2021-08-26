using System;
using Microsoft.Xna.Framework;

namespace ccd {
    
    public class Komponent {

        public Entitet entitet;
        public virtual void Uppdatera(GameTime gameTime){}
    }
}