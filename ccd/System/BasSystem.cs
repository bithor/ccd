using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ccd {

    class BasSystem<T> where T : Komponent {

        public static List<T> komponenter = new List<T>();

        public static void Register(T komponent)
        {
            komponenter.Add(komponent);
        }

        public static void Uppdatera(GameTime gameTime)
        {
            foreach (T komponent in komponenter)
            {
                komponent.Uppdatera(gameTime);
            }
        }

    }

    class TransformSystem : BasSystem<Transform> { }
    class SpriteSystem : BasSystem<Sprite> {
        
        public static void Rita(SpriteBatch spriteBatch) {
            foreach (Sprite komponent in komponenter) {
                spriteBatch.Draw(komponent.Textur, komponent.Position, Color.White);
            }
        }
    }
    class KolliderarSystem : BasSystem<Kolliderare> { }
    class RorelseSystem : BasSystem<Rorelse> { }
    class InputSystem : BasSystem<Input> { }
}