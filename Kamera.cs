using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace ccd {
    public class Kamera {
		public static Matrix Transform { get; private set; }

		public static void Follow(Vector2 target) {
			var position = Matrix.CreateTranslation(-target.X, -target.Y, 0); // follows target

			var offset = Matrix.CreateTranslation(320, 240, 0); // half screen width/height hardcoded

			Transform = position * offset;
		}
	}
}