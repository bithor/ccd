using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace ccd {

    public class KollisionsHanterare {

        public List<Rectangle> Colliders = new List<Rectangle>();
        public Rectangle SpelarHitBox;
        public Tillstand SpelarTillstand;
        public KollisionsHanterare(){
            
        }
        public void KollisionsKoll(List<Objekt> Objekt) {

            for (int i = 0; i < Objekt.Count; i++)
            {
                for (int j = i + 1; j < Objekt.Count; j++)
                {
                    Objekt[i].Kolliderar = SpelarHitBox.Intersects(Objekt[j].HitBox);
                    System.Console.WriteLine("objekt" + i + " objekt" + j);

                    if(Objekt[i].Kolliderar && Objekt[i].Tillstand == Tillstand.Attack){
                        Objekt[j].HP = 0;
                    System.Console.WriteLine(Objekt[j].HP);
                    }
                }

            }
        }
    }

}