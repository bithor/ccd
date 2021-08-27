using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace ccd {
    public class Kolliderare : Komponent {
        // implementation of a Collider component

        public Rectangle YttreLada;
        public Rectangle InreLada;
        public bool Kolliderar;
        public Kolliderare() {
            Kolliderar = false;
            KolliderarSystem.Register(this);
        }

    }
}