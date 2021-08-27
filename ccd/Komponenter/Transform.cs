using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace ccd {
    public class Transform : Komponent {
        public Vector2 Position = Vector2.Zero;
        public Vector2 scale = Vector2.Zero;
        public float layerDepth = 0;
        public float rotation = 0;

        public Transform()
        {
            TransformSystem.Register(this);
        }



    }
}