using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ccd {
    class Rorelse : Komponent {
        
        public bool Hoger;
        public bool Vanster;
        public bool Upp;
        public bool Ner;
        private float acceleration = 4000.0f;
        private float hMovement = 0f;
        private float hVelocity = 0f;
        private float vMovement = 0f;
        private float vVelocity = 0f;
        private float MaxMoveSpeed = 400.0f;
        private Vector2 TempPosition;

        public Rorelse() {
            RorelseSystem.Register(this);
        }

        public override void Uppdatera(GameTime gameTime){

            float delta = (float)gameTime.ElapsedGameTime.TotalSeconds;

            Sprite sprite = entitet.GetKomponent<Sprite>();
            Kolliderare kolliderare = entitet.GetKomponent<Kolliderare>();
            
            TempPosition = sprite.Position;
            
            hMovement = 0.0f;
            vMovement = 0.0f;

            if (Hoger) {
                hVelocity += 1.0f * acceleration * delta;
                hVelocity = MathHelper.Clamp(hVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                TempPosition.X += hVelocity * delta;

                if(!kolliderare.Kolliderar){
                    hVelocity += 1.0f * acceleration * delta;
                    hVelocity = MathHelper.Clamp(hVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                    sprite.Position.X += hVelocity * delta;
                }
                hMovement = 1.0f;
            }
            if (Vanster) {
                hVelocity += 1.0f * acceleration * delta;
                hVelocity = MathHelper.Clamp(hVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                TempPosition.X -= hVelocity * delta;

                if(!kolliderare.Kolliderar){
                    hVelocity += 1.0f * acceleration * delta;
                    hVelocity = MathHelper.Clamp(hVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                    sprite.Position.X -= hVelocity * delta;
                }
                hMovement = -1.0f;
            }
            if (Upp) {
                vVelocity += 1.0f * acceleration * delta;
                vVelocity = MathHelper.Clamp(vVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                TempPosition.Y -= vVelocity * delta;

                if(!kolliderare.Kolliderar){
                    vVelocity += 1.0f * acceleration * delta;
                    vVelocity = MathHelper.Clamp(vVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                    sprite.Position.Y -= vVelocity * delta;
                }
                vMovement = -1.0f;
            }
            if (Ner) {
                vVelocity += 1.0f * acceleration * delta;
                vVelocity = MathHelper.Clamp(vVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                TempPosition.Y += vVelocity * delta;

                if(!kolliderare.Kolliderar){
                    vVelocity += 1.0f * acceleration * delta;
                    vVelocity = MathHelper.Clamp(vVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                    sprite.Position.Y += vVelocity * delta;

                }
                vMovement = 1.0f;
            }  
        }
    }
}