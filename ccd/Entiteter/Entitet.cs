using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace ccd {

    public class Entitet {
        public int id { get; set; }
        List<Komponent> komponenter = new List<Komponent>();

        public void AddKomponent(Komponent komponent){
            komponenter.Add(komponent);
            komponent.entitet = this;
        }

        public T GetKomponent<T>() where T : Komponent {
            foreach (Komponent komponent in komponenter)
            {
                if (komponent.GetType().Equals(typeof(T)))
                {
                    return (T)komponent;
                }
            }
            return null;
        }
    }
}