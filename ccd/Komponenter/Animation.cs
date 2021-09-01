using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ccd {
    public class Animation : Komponent {
        public Texture2D Textur;
        public Transform transform;
        public Rectangle[,] Rectangles;
        public Facing Facing;
        public int FrameIndex = 0;
        public int Frames;
        private float Timer = 0f;
        private float AnimationsHastighet;
        public int width;
        public int height;
        public int ValdRad;
        public Animation(Texture2D textur, int frames, int rader, float animationsHastighet) {
            Textur = textur;
            AnimationsHastighet = animationsHastighet;
            Frames = frames;
            width = Textur.Width / frames;
            height = Textur.Height / rader;
            Rectangles = new Rectangle[rader, frames];
            for (int i = 0; i < rader; i++) {
                for (int y = 0; y < frames; y++){
                    Rectangles[i, y] = new Rectangle(
                        y * width, i * height, width, height
                    );
                }
            }

            AnimationsSystem.Register(this);
        }

        public override void Uppdatera(GameTime gameTime) {
            transform = entitet.GetKomponent<Transform>();
            
            Facing = entitet.Facing;
            ValdRad = (int)entitet.Tillstand;

            float delta = (float)gameTime.ElapsedGameTime.TotalSeconds;
            Timer += AnimationsHastighet * delta;
            if(Timer > 1f){
                FrameIndex += 1;
                Timer = 0f;
            }
            if(FrameIndex == Frames){
                FrameIndex = 0;
            }

        }

        public void Rita(SpriteBatch spriteBatch) {
            if(Facing == Facing.Hoger){
                spriteBatch.Draw(Textur, transform.Position, Rectangles[ValdRad, FrameIndex], Color.White, 0f, Vector2.Zero, 
                1f, SpriteEffects.None, 0f); 
            }
            if(Facing == Facing.Vanster){
                spriteBatch.Draw(Textur, transform.Position, Rectangles[ValdRad, FrameIndex], Color.White, 0f, Vector2.Zero, 
                1f, SpriteEffects.FlipHorizontally, 0f);  
            }
        }
    }
}