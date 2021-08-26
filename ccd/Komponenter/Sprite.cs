using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ccd {
    class Sprite : Komponent {
        // implementation of a Collider component
        public Texture2D Textur;
        public Vector2 Position;

        public Sprite() {
            Position = new Vector2(155, 155);
            Textur = SpelResurser.Yxa;
            SpriteSystem.Register(this);
        }

        public override void Uppdatera(GameTime gameTime) {
        }
    }
}