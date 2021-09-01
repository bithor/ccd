using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace ccd {
    public class Transform : Komponent {
        public Vector2 Position = Vector2.Zero;
        public Vector2 TempPosition = Vector2.Zero;
        public Vector2 scale = Vector2.Zero;
        public float layerDepth = 0;
        public float rotation = 0;

        public Transform(float X = 155, float Y = 155){
            Position = new Vector2(X, Y);
            TempPosition = Position;
            TransformSystem.Register(this);
        }



    }
}