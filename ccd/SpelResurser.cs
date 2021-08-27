using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace ccd {
    //classen som inhåller alla spel resurser för tillfället
    public class SpelResurser {
        // Döp ALLTID Variablerna med likvärdig Mönster T.ex om MinVariabel är av Texture2D så Ska Det Vara MinVariabelTextur
        public static Texture2D GolvTextur { get; set; }
        public static Texture2D BakgrundTextur { get; set; }
        public static Texture2D HimmelTextur { get; set; }
        public static Texture2D DougNormalTextur { get; set; }
        public static Texture2D DougPromenad { get; set; }
        public static Texture2D DougIdle { get; set; }
        public static Texture2D DougAttackTextur { get; set; }
        public static Texture2D RandyNormalTextur { get; set; }
        public static Texture2D RandyAttackTextur { get; set; } 
        public static Texture2D Yxa { get; set; }
        public static Texture2D InventorySlot { get; set; }
        
        public SpelResurser(ContentManager Content) {
            /////////////// Texturer För kulissen 
            GolvTextur = Content.Load<Texture2D>("mark");
            BakgrundTextur = Content.Load<Texture2D>("bakgrund");//byt till korrekt sen
            HimmelTextur = Content.Load<Texture2D>("himmel"); //byt till korrekt sen
            ///////////////
            DougNormalTextur = Content.Load<Texture2D>("doug");
            DougPromenad = Content.Load<Texture2D>("doug_promenad");
            DougIdle = Content.Load<Texture2D>("doug_idle");
            DougAttackTextur = Content.Load<Texture2D>("dougattack");
            RandyNormalTextur = Content.Load<Texture2D>("randy");
            RandyAttackTextur = Content.Load<Texture2D>("randy_attack");
            ////
            Yxa = Content.Load<Texture2D>("Yxa");
            InventorySlot = Content.Load<Texture2D>("InventorySlot");
        }
    }
}
