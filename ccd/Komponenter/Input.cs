using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ccd {
    public class Input : Komponent {

        public Input(){
            InputSystem.Register(this);
        }
        public override void Uppdatera(GameTime gameTime){

            KeyboardState state = Keyboard.GetState();

            Rorelse rorelse = entitet.GetKomponent<Rorelse>();

            rorelse.Hoger = false;
            rorelse.Vanster = false;
            rorelse.Upp = false;
            rorelse.Ner = false;

            if (state.IsKeyDown(Keys.Right)) {
                rorelse.Hoger = true;
            }
            if (state.IsKeyDown(Keys.Left)) {
                rorelse.Vanster = true;
            }
            if(state.IsKeyDown(Keys.Up)){
                rorelse.Upp = true;
            }
            if(state.IsKeyDown(Keys.Down)){
                rorelse.Ner = true;
            }
        }
    }
}