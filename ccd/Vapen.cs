using Microsoft.Xna.Framework.Graphics;

namespace ccd {

    public class Vapen : Item {

        public Vapen(string namn, string besk, Texture2D textur) : base(namn, besk, textur) {
            Namn = namn;
            Besk = besk;
            Textur = textur;
        }
    }
}