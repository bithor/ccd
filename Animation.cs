using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ccd {
    public class Animation {

        public Texture2D Textur;
        public Vector2 Position = new Vector2(0, 0);
        public Rectangle[] Rectangles;
        public Facing Facing;
        public int FrameIndex = 0;
        public int Frames;
        private float Timer = 0f;
        private float AnimationsHastighet;
        public int width;

        public Animation(Texture2D textur, int frames, float animationsHastighet) {
            Textur = textur;
            AnimationsHastighet = animationsHastighet;
            Frames = frames;
            width = Textur.Width / frames;
            Rectangles = new Rectangle[frames];
            for (int i = 0; i < frames; i++){
                Rectangles[i] = new Rectangle(
                    i * width, 0, width, Textur.Height
                );
            }
        }

        public void Uppdatera(GameTime gameTime){
            var delta = (float)gameTime.ElapsedGameTime.TotalSeconds;
            Timer += AnimationsHastighet * delta;
            if(Timer > 1f){
                FrameIndex += 1;
                Timer = 0f;
            }
            if(FrameIndex == Frames){
                FrameIndex = 0;
            }
        }
        public void Rita(SpriteBatch spriteBatch, Vector2 position, Facing facing){
            Position = position;
            Facing = facing;
            if(Facing == Facing.Hoger){
                spriteBatch.Draw(Textur, Position, Rectangles[FrameIndex], Color.White, 0f, Vector2.Zero, 
                1f, SpriteEffects.None, 0f); 
            }
            if(Facing == Facing.Vanster){
                spriteBatch.Draw(Textur, Position, Rectangles[FrameIndex], Color.White, 0f, Vector2.Zero, 
                1f, SpriteEffects.FlipHorizontally, 0f);  
            }
        }
    }
}