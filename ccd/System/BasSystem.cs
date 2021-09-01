using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;

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
                spriteBatch.Draw(komponent.Textur, komponent.transform.Position, Color.White);
            }
        }
    }
    public class AnimationsSystem : BasSystem<Animation> {
        public static void Rita(SpriteBatch spriteBatch){
            foreach ( Animation komponent in komponenter){
                komponent.Rita(spriteBatch);
            }
        }
    }
    public class KolliderarSystem : BasSystem<Kolliderare> {

        public static Kolliderare SpelarKolliderare;
        public static void KollisionsKoll(GameTime gameTime){
            
            Kolliderare[] KolliderarLista = komponenter.ToArray();
            System.Console.WriteLine(SpelarKolliderare.YttreLada);

            for (int i = 0; i < KolliderarLista.Count(); i++) {
                System.Console.WriteLine(KolliderarLista[i].YttreLada);
                SpelarKolliderare.Kolliderar = SpelarKolliderare.YttreLada.Intersects(KolliderarLista[i].YttreLada);
            }

            for (int i = 0; i < KolliderarLista.Count(); i++) {
                for (int j = 0; j < KolliderarLista.Count(); j++)
                {
                    if(j != i){
                        KolliderarLista[i].Kolliderar = KolliderarLista[i].YttreLada.Intersects(KolliderarLista[j].YttreLada);
                        System.Console.WriteLine("objekt" + i + " objekt" + j);
                    }
                }
            }
        }
    }
    public class RorelseSystem : BasSystem<Rorelse> { }
    public class InputSystem : BasSystem<Input> { }
}