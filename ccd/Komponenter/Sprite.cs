using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ccd {
    public class Sprite : Komponent {
        public Texture2D Textur;
        public Vector2 Position;
        public Facing facing;
        public Tillstand tillstand;
        public Sprite(float X = 155, float Y = 155) {
            Position = new Vector2(X, Y);
            Textur = SpelResurser.Yxa;
            SpriteSystem.Register(this);
        }

        public override void Uppdatera(GameTime gameTime) {
        }
    }
}