using System;
using System.Collections.Generic;

namespace ccd {
    public class Entitet {
        public int ID { get; private set; }
        private Dictionary<Type, Komponent> Komponenter;
    
        public Entitet(int id)
        {
            ID = id;
            Komponenter = new Dictionary<Type, Komponent>();
        }
    
        internal void LaggTillKomponent(Komponent Komponent)
        {
            Komponenter[Komponent.GetType()] = Komponent;
        }
    
        internal void TaBortKomponent<T>() where T : Komponent
        {
            Komponenter.Remove(typeof(T));
        }
    
        public T TaKomponent<T>() where T : Komponent
        {
            return (T)Komponenter[typeof(T)];
        }
    
        public bool HarKomponent(Type KomponentType)
        {
            return Komponenter.ContainsKey(KomponentType);
        }
    
        public bool HarKomponent<T>() where T : Komponent
        {
            return Komponenter.ContainsKey(typeof(T));
        }
    }
}
