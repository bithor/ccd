using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ccd {
    public class Sprite : Komponent {
        public Texture2D Textur;
        public Transform transform;
        public Sprite() {
            Textur = SpelResurser.Yxa;
            SpriteSystem.Register(this);
        }

        public Sprite(Texture2D textur) {
            Textur = textur;
            SpriteSystem.Register(this);
        }

        public override void Uppdatera(GameTime gameTime) {
            transform = entitet.GetKomponent<Transform>();
        }
    }
}