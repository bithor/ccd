using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ccd {

    public class HUD {
        
        public InventoryGUI inventoryGUI = new InventoryGUI();
        private SpriteBatch spriteBatch;
        public HUD(SpriteBatch spriteBatch) {
            this.spriteBatch = spriteBatch;
        }
        public void Uppdatera(GameTime gameTime, Inventory inventory, Vector2 position){
            inventoryGUI.Uppdatera(gameTime, inventory, position);
        }

        public void Rita(){
            inventoryGUI.Rita(spriteBatch);
        }
        
    }

    public class InventoryGUI {
        private InventorySlot[] inventorySlot;
        private Vector2 Position;


        public void Uppdatera(GameTime gameTime, Inventory inventory, Vector2 position) {
            inventorySlot = new InventorySlot[inventory.Storlek];
            for (int i = 0; i < inventorySlot.Length; i++){
                inventorySlot[i] = new InventorySlot(SpelResurser.InventorySlot);
                inventorySlot[i].Position.X = position.X + ( i * 50 );
                inventorySlot[i].Position.Y = position.Y + 70;  
            }
            
        }

        public void Rita(SpriteBatch spriteBatch){
            for (int i = 0; i < inventorySlot.Length; i++)
            {
                inventorySlot[i].Rita(spriteBatch);
            }
        }

    }

    public class InventorySlot {
        public Vector2 Position;
        public Texture2D Textur;
        public bool Vald;

        public InventorySlot(Texture2D textur){
            Textur = textur;
        }

        public void Rita(SpriteBatch spriteBatch){
            spriteBatch.Draw(Textur, Position, Color.White);
        }

    }
}