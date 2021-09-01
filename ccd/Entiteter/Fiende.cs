using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ccd {

    public class Fiende : Entitet {
        public Fiende(int X = 200, int Y = 200) {
            Tillstand = Tillstand.Idle;

            Transform transform = new Transform(X, Y);
            AddKomponent(transform);

            Animation animation = new Animation(SpelResurser.Doug_SpriteSheet, 6, 3, 10f);
            AddKomponent(animation);

            Kolliderare kolliderare = new Kolliderare();
            AddKomponent(kolliderare);

        }
    }

        public class BasFiende : Entitet {
        public BasFiende(int X = 200, int Y = 200) {
            Tillstand = Tillstand.Idle;

            Transform transform = new Transform(X, Y);
            AddKomponent(transform);

            Animation animation = new Animation(SpelResurser.Doug_SpriteSheet, 6, 3, 10f);
            AddKomponent(animation);

            Kolliderare kolliderare = new Kolliderare();
            AddKomponent(kolliderare);

        }
    }
}
