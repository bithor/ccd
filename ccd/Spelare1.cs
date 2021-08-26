using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ccd {

    public enum Tillstand {
        Idle = 0,
        Promenad = 1,
        Attack = 2,
        Doed = 3
    }

    public enum Facing {
        Hoger,
        Vanster
    }
/*    public class Spelare1 : Objekt {
        private Vector2 TempPosition;
        private Facing Facing;
        private AnimationsHanterare animationsHanterare;
        public Inventory Inventory;
        private Item ValdItem;
        private float acceleration = 4000.0f;
        private float hMovement = 0f;
        private float hVelocity = 0f;
        private float vMovement = 0f;
        private float vVelocity = 0f;
        private float MaxMoveSpeed = 400.0f;
        private float AttackTimer;
        public Spelare(SpriteBatch spriteBatch, SpelResurser spelResurser) : base(spriteBatch, spelResurser)
        {
            SpriteBatch = spriteBatch;
            SpelResurser = spelResurser;
            Position = new Vector2(0, 0);
            animationsHanterare = new AnimationsHanterare(SpelResurser);
            Inventory = new Inventory(2);
            for (int i = 0; i < Inventory.Items.Length - 1; i++)
            {
                Inventory.Items[i] = new Vapen("yxa", "yxa.besk", SpelResurser.Yxa);
            }
        }

        public void Ladda(){
            animationsHanterare = new AnimationsHanterare(SpelResurser);
        }
        public override void Rita() {
            //SpriteBatch.Draw(SpelResurser.DougNormalTextur, Position, Color.White);
            animationsHanterare.Rita(SpriteBatch, Position);
        }

        public override string ToString() {
            return base.ToString();
        }

        public override void Uppdatera(GameTime gameTime) {
            Rorelse(gameTime);
            Attack(gameTime);
            animationsHanterare.Uppdatera(gameTime, Tillstand, Facing);
            HitBoxHanterare();
            //System.Console.WriteLine(Kolliderar);
        }

        private void Attack(GameTime gameTime) {
            System.Console.WriteLine(Tillstand);
            if(InputHanterare.AttackKnapp && AttackTimer == 0f) {
                Tillstand = Tillstand.Attack;
                AttackTimer = 0.25f;
            }
            if(AttackTimer > 0){
                var delta = (float)gameTime.ElapsedGameTime.TotalSeconds;
                AttackTimer -= 1.0f * delta;
                AttackTimer = MathHelper.Clamp(AttackTimer, 0f, 10f);
                System.Console.WriteLine(AttackTimer);
            }
            if(AttackTimer == 0 && !InputHanterare.HogerKnapp && !InputHanterare.VansterKnapp && !InputHanterare.UppKnapp && !InputHanterare.NerKnapp){
                Tillstand = Tillstand.Idle;
            }
        }

        private void HitBoxHanterare() {
            if(Tillstand == Tillstand.Promenad || Tillstand == Tillstand.Idle){
                HitBox = new Rectangle((int)TempPosition.X, (int)TempPosition.Y, animationsHanterare.Animationer[0].width, animationsHanterare.Animationer[0].Textur.Height);
            }else if(Tillstand == Tillstand.Attack) {
                HitBox = new Rectangle((int)TempPosition.X, (int)TempPosition.Y, animationsHanterare.Animationer[2].width, animationsHanterare.Animationer[2].Textur.Height);
            }
        }
        private void Rorelse(GameTime gameTime) {
            KeyboardState state = Keyboard.GetState();

            var delta = (float)gameTime.ElapsedGameTime.TotalSeconds;

            //Tillstand = Tillstand.Idle;
            
            TempPosition = Position;

            hMovement = 0.0f;
            vMovement = 0.0f;

            if (InputHanterare.HogerKnapp) {
                hVelocity += 1.0f * acceleration * delta;
                hVelocity = MathHelper.Clamp(hVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                TempPosition.X += hVelocity * delta;

                if(!Kolliderar){
                    hVelocity += 1.0f * acceleration * delta;
                    hVelocity = MathHelper.Clamp(hVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                    Position.X += hVelocity * delta;
                }
                hMovement = 1.0f;
                Tillstand = Tillstand.Promenad;
                Facing = Facing.Hoger;

            }
            if (InputHanterare.VansterKnapp) {
                hVelocity += 1.0f * acceleration * delta;
                hVelocity = MathHelper.Clamp(hVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                TempPosition.X -= hVelocity * delta;

                if(!Kolliderar){
                    hVelocity += 1.0f * acceleration * delta;
                    hVelocity = MathHelper.Clamp(hVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                    Position.X -= hVelocity * delta;
                }
                hMovement = -1.0f;
                Tillstand = Tillstand.Promenad;
                Facing = Facing.Vanster;
            }
            if (InputHanterare.UppKnapp) {
                vVelocity += 1.0f * acceleration * delta;
                vVelocity = MathHelper.Clamp(vVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                TempPosition.Y -= vVelocity * delta;

                if(!Kolliderar){
                    vVelocity += 1.0f * acceleration * delta;
                    vVelocity = MathHelper.Clamp(vVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                    Position.Y -= vVelocity * delta;
                }
                vMovement = -1.0f;
                Tillstand = Tillstand.Promenad;
            }
            if (InputHanterare.NerKnapp) {
                vVelocity += 1.0f * acceleration * delta;
                vVelocity = MathHelper.Clamp(vVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                TempPosition.Y += vVelocity * delta;

                if(!Kolliderar){
                    vVelocity += 1.0f * acceleration * delta;
                    vVelocity = MathHelper.Clamp(vVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                    Position.Y += vVelocity * delta;

                }
                vMovement = 1.0f;
                Tillstand = Tillstand.Promenad;
            }
            
            if(Tillstand == Tillstand.Promenad) {
                if(state.IsKeyUp(Keys.Right) && state.IsKeyUp(Keys.Left) && state.IsKeyUp(Keys.Up) && state.IsKeyUp(Keys.Down)) {
                    Tillstand = Tillstand.Idle;
                }
                if(state.IsKeyUp(Keys.Right) && state.IsKeyUp(Keys.Left)){
                    hVelocity = 0.0f;
                }
                if(state.IsKeyUp(Keys.Up) && state.IsKeyUp(Keys.Down)){
                    vVelocity = 0.0f;
                }
            }else if (Tillstand == Tillstand.Idle) {
                hVelocity *= 0.5f;
                vVelocity *= 0.5f;

                if(hVelocity < 0.5f){
                    hVelocity = 0.0f;
                }
                if(vVelocity < 0.5f){
                    vVelocity = 0.0f;
                }
            }  
        }
    }*/
}