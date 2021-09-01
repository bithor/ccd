using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ccd {
    public class Rorelse : Komponent {
        
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

        public Rorelse() {
            RorelseSystem.Register(this);
        }

        public override void Uppdatera(GameTime gameTime){

            float delta = (float)gameTime.ElapsedGameTime.TotalSeconds;

            Transform transform = entitet.GetKomponent<Transform>();
            Kolliderare kolliderare = entitet.GetKomponent<Kolliderare>();
            bool kuk = false;
            transform.TempPosition = transform.Position;
            
            hMovement = 0.0f;
            vMovement = 0.0f;

            if (Hoger) {
                hVelocity += 1.0f * acceleration * delta;
                hVelocity = MathHelper.Clamp(hVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                transform.TempPosition.X += hVelocity * delta;

                if(!kuk){
                    hVelocity += 1.0f * acceleration * delta;
                    hVelocity = MathHelper.Clamp(hVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                    transform.Position.X += hVelocity * delta;
                    entitet.Tillstand = Tillstand.Promenad;
                    entitet.Facing = Facing.Hoger;
                }
                hMovement = 1.0f;
            }
            if (Vanster) {
                hVelocity += 1.0f * acceleration * delta;
                hVelocity = MathHelper.Clamp(hVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                transform.TempPosition.X -= hVelocity * delta;

                if(!kuk){
                    hVelocity += 1.0f * acceleration * delta;
                    hVelocity = MathHelper.Clamp(hVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                    transform.Position.X -= hVelocity * delta;
                    entitet.Tillstand = Tillstand.Promenad;
                    entitet.Facing = Facing.Vanster;
                }
                hMovement = -1.0f;
            }
            if (Upp) {
                vVelocity += 1.0f * acceleration * delta;
                vVelocity = MathHelper.Clamp(vVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                transform.TempPosition.Y -= vVelocity * delta;

                if(!kuk){
                    vVelocity += 1.0f * acceleration * delta;
                    vVelocity = MathHelper.Clamp(vVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                    transform.Position.Y -= vVelocity * delta;
                    entitet.Tillstand = Tillstand.Promenad;
                }
                vMovement = -1.0f;
            }
            if (Ner) {
                vVelocity += 1.0f * acceleration * delta;
                vVelocity = MathHelper.Clamp(vVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                transform.TempPosition.Y += vVelocity * delta;

                if(!kuk){
                    vVelocity += 1.0f * acceleration * delta;
                    vVelocity = MathHelper.Clamp(vVelocity, -MaxMoveSpeed, MaxMoveSpeed);
                    transform.Position.Y += vVelocity * delta;
                    entitet.Tillstand = Tillstand.Promenad;
                }
                vMovement = 1.0f;
            }

            if(entitet.Tillstand == Tillstand.Promenad) {
                if(!Hoger && !Vanster && !Upp && !Ner) {
                    entitet.Tillstand = Tillstand.Idle;
                }
                if(!Hoger && !Vanster){
                    hVelocity = 0.0f;
                }
                if(!Upp && !Ner){
                    vVelocity = 0.0f;
                }
            }else if (entitet.Tillstand == Tillstand.Idle) {
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