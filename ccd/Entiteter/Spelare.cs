using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ccd {

    public class Spelare : Entitet {
        public Spelare() {
            Animation animation = new Animation(SpelResurser.Doug_SpriteSheet, 6, 3, 10f);
            AddKomponent(animation);

            Rorelse rorelse = new Rorelse();
            AddKomponent(rorelse);

            Input input = new Input();
            AddKomponent(input);

            Kolliderare kolliderare = new Kolliderare(5);
            AddKomponent(kolliderare);

            Transform transform = new Transform();
            AddKomponent(transform);
        }
    }
}