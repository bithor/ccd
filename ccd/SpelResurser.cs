using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using TiledCS;
using TiledCS.MonoGame.Rendering;


namespace ccd {
    //classen som inhåller alla spel resurser för tillfället
    public class SpelResurser {
        // Döp ALLTID Variablerna med likvärdig Mönster T.ex om MinVariabel är av Texture2D så Ska Det Vara MinVariabelTextur
        public Texture2D GolvTextur { get; set; }
        public Texture2D BakgrundTextur { get; set; }
        public Texture2D HimmelTextur { get; set; }
        public Texture2D DougNormalTextur { get; set; }
        public Texture2D DougPromenad { get; set; }
        public Texture2D DougIdle { get; set; }
        public Texture2D DougAttackTextur { get; set; }
        public Texture2D RandyNormalTextur { get; set; }
        public Texture2D RandyAttackTextur { get; set; } 
        public TiledMap Karta { get; set; }
        public SpelResurser(ContentManager Content) {
            Karta = Content.Load<TiledMap>("SpelKarta");
            /////////////// Texturer För kulissen 
            GolvTextur = Content.Load<Texture2D>("mark");
            BakgrundTextur = Content.Load<Texture2D>("bakgrund");//byt till korrekt sen
            HimmelTextur = Content.Load<Texture2D>("himmel"); //byt till korrekt sen
            ///////////////
            DougNormalTextur = Content.Load<Texture2D>("doug");
            DougPromenad = Content.Load<Texture2D>("doug_promenad");
            DougIdle = Content.Load<Texture2D>("doug_idle");
            DougAttackTextur = Content.Load<Texture2D>("doug_attack");
            RandyNormalTextur = Content.Load<Texture2D>("randy");
            RandyAttackTextur = Content.Load<Texture2D>("randy_attack");
        }
    }
}
