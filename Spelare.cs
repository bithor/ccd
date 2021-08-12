using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ccd {

    public enum Tillstand {
        Idle = 0,
        Promenad = 1,
        Attack = 2
    }

    public enum Facing {
        Hoger,
        Vanster
    }
    public class Spelare : Objekt {

        public Vector2 Position;
        private Vector2 TempPosition;
        public Rectangle HitBox;
        private SpriteBatch SpriteBatch;
        private Tillstand SpelarStatus;
        private Facing Facing;
        private AnimationsHanterare animationsHanterare;
        private float acceleration = 4000.0f;
        private float hMovement = 0f;
        private float hVelocity = 0f;
        private float vMovement = 0f;
        private float vVelocity = 0f;
        private float MaxMoveSpeed = 400.0f;

        public bool Kolliderar = false;

        public Spelare(SpriteBatch spriteBatch, SpelResurser spelResurser) : base(spriteBatch, spelResurser)
        {
            SpriteBatch = spriteBatch;
            SpelResurser = spelResurser;
            Position = new Vector2(0, 0);
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
            animationsHanterare.Uppdatera(gameTime, SpelarStatus, Facing);
            //System.Console.WriteLine(Kolliderar);
            HitBox = new Rectangle((int)TempPosition.X, (int)TempPosition.Y, animationsHanterare.Animationer[0].width, animationsHanterare.Animationer[0].Textur.Height);
        }

        private void Rorelse(GameTime gameTime) {
            KeyboardState state = Keyboard.GetState();

            var delta = (float)gameTime.ElapsedGameTime.TotalSeconds;

            SpelarStatus = Tillstand.Idle;
            
            TempPosition = Position;

            hMovement = 0.0f;
            vMovement = 0.0f;

            if (state.IsKeyDown(Keys.Right)) {
                hVelocity += 1.0f * acceleration * delta;
                hVelocity = MathHelper.Clamp(hVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                TempPosition.X += hVelocity * delta;

                if(!Kolliderar){
                    hVelocity += 1.0f * acceleration * delta;
                    hVelocity = MathHelper.Clamp(hVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                    Position.X += hVelocity * delta;
                }
                hMovement = 1.0f;
                SpelarStatus = Tillstand.Promenad;
                Facing = Facing.Hoger;

            }
            if (state.IsKeyDown(Keys.Left)) {
                hVelocity += 1.0f * acceleration * delta;
                hVelocity = MathHelper.Clamp(hVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                TempPosition.X -= hVelocity * delta;

                if(!Kolliderar){
                    hVelocity += 1.0f * acceleration * delta;
                    hVelocity = MathHelper.Clamp(hVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                    Position.X -= hVelocity * delta;
                }
                hMovement = -1.0f;
                SpelarStatus = Tillstand.Promenad;
                Facing = Facing.Vanster;
            }
            if (state.IsKeyDown(Keys.Up)) {
                vVelocity += 1.0f * acceleration * delta;
                vVelocity = MathHelper.Clamp(vVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                TempPosition.Y -= vVelocity * delta;

                if(!Kolliderar){
                    vVelocity += 1.0f * acceleration * delta;
                    vVelocity = MathHelper.Clamp(vVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                    Position.Y -= vVelocity * delta;
                }
                vMovement = -1.0f;
                SpelarStatus = Tillstand.Promenad;
            }
            if (state.IsKeyDown(Keys.Down)) {
                vVelocity += 1.0f * acceleration * delta;
                vVelocity = MathHelper.Clamp(vVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                TempPosition.Y += vVelocity * delta;

                if(!Kolliderar){
                    vVelocity += 1.0f * acceleration * delta;
                    vVelocity = MathHelper.Clamp(vVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                    Position.Y += vVelocity * delta;

                }
                vMovement = 1.0f;
                SpelarStatus = Tillstand.Promenad;
            }
            
            if(SpelarStatus == Tillstand.Promenad) {
                if(state.IsKeyUp(Keys.Right) && state.IsKeyUp(Keys.Left)){
                    hVelocity = 0.0f;
                }
                if(state.IsKeyUp(Keys.Up) && state.IsKeyUp(Keys.Down)){
                    vVelocity = 0.0f;
                }
            }else if (SpelarStatus == Tillstand.Idle) {
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
    }
}