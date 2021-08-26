using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ccd {

    public abstract class Item {

        public string Namn;
        public string Besk;
        public Texture2D Textur;

        public Vector2 Position;
        public bool RitaPkartan;

        public Item(string namn, string besk, Texture2D textur){
            Namn = namn;
            Besk = besk;
            Textur = textur;
        }
    }
}