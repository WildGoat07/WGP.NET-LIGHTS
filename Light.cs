using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML;
using SFML.System;
using SFML.Graphics;
using SFML.Window;

namespace WGP.LIGHTS
{
    /// <summary>
    /// Basic light. 
    /// </summary>
    public class Light
    {
        internal Light()
        {
            Radius = 0;
            Angle = Angle.Zero;
            Field = Angle.Loop;
            Color = Color.White;
        }
        /// <summary>
        /// Position of the center of the light.
        /// </summary>
        public Vector2f Position { get; set; }
        /// <summary>
        /// Radius of the light.
        /// </summary>
        public float Radius { get; set; }
        /// <summary>
        /// The precision is an index between 0 and 1, corresponding to the number of vertex per degree.
        /// </summary>
        public float Precision { get; set; }
        /// <summary>
        /// The angle of the light. The light will point to this angle. Visible only if the Field is smaller than 360.
        /// </summary>
        public Angle Angle { get; set; }
        /// <summary>
        /// Field of the spot light.
        /// </summary>
        public Angle Field { get; set; }
        /// <summary>
        /// Color of the light.
        /// </summary>
        public Color Color { get; set; }
    }
}
