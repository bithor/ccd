using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ccd {
    public enum KnappTryck {
            Inget,
            Hoger,
            Vanster,
            Upp,
            Ner,
            Attack
        }

    public class InputHanterare {

        public static bool HogerKnapp;
        public static bool VansterKnapp;
        public static bool UppKnapp;
        public static bool NerKnapp;
        public static bool AttackKnapp;


        public static KnappTryck KnappTryck;


        public static void Uppdatera(GameTime gameTime) {
            HogerKnapp = false;
            VansterKnapp = false;
            UppKnapp = false;
            NerKnapp = false;
            AttackKnapp = false;
            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.Right)) {
                HogerKnapp = true;
            }
            if (state.IsKeyDown(Keys.Left)) {
                VansterKnapp = true;
            }
            if(state.IsKeyDown(Keys.Up)){
                UppKnapp = true;
            }
            if(state.IsKeyDown(Keys.Down)){
                NerKnapp = true;
            }
            if(state.IsKeyDown(Keys.Z)){
                AttackKnapp = true;
            }
        }

    }
}