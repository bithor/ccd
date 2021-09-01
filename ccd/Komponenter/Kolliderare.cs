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
            KolliderarSystem.Register(this);
        }

        public Kolliderare(int spelare) {
            KolliderarSystem.SpelarKolliderare = this;
            KolliderarSystem.Register(this);
        }

        public override void Uppdatera(GameTime gameTime){
            Animation Dimensioner = entitet.GetKomponent<Animation>();
            Transform Position = entitet.GetKomponent<Transform>();
            YttreLada = new Rectangle((int)Position.TempPosition.X, (int)Position.TempPosition.Y, Dimensioner.width, Dimensioner.height);
            System.Console.WriteLine(Kolliderar);
        }

    }
}