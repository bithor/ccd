using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ccd {

    public class BasSystem<T> where T : Komponent {

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

    public class TransformSystem : BasSystem<Transform> { }
    public class SpriteSystem : BasSystem<Sprite> {
        
        public static void Rita(SpriteBatch spriteBatch) {
            foreach (Sprite komponent in komponenter) {
                spriteBatch.Draw(komponent.Textur, komponent.Position, Color.White);
            }
        }
    }
    public class KolliderarSystem : BasSystem<Kolliderare> { }
    public class RorelseSystem : BasSystem<Rorelse> { }
    public class InputSystem : BasSystem<Input> { }
}