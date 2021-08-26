using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace ccd {

    public abstract class Status {         
        protected Game1 CCD;          
        protected ContentManager Innehall;   
        public SpriteBatch SpriteBatch;               
        public Status(Game1 spel, ContentManager innehall) {
            CCD = spel; 
            Innehall = innehall;
            SpriteBatch = spel._spriteBatch;
        }                  
        public abstract void Initialisera(); 
        public abstract void LoadContent();      
        public abstract void Uppdatera(GameTime gameTime);                  
        public abstract void EfterUppdatering(GameTime gameTime);          
        public abstract void Rita(GameTime gameTime);            
    }
}