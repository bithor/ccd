using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ccd {

    public class Spelare : Entitet {
        public Spelare() {
            Sprite sprite = new Sprite();
            AddKomponent(sprite);
            Rorelse rorelse = new Rorelse();
            AddKomponent(rorelse);
            Input input = new Input();
            AddKomponent(input);
            Kolliderare kolliderare = new Kolliderare();
            AddKomponent(kolliderare);
        }
    }
}