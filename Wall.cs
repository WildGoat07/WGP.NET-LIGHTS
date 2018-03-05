using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.System;

namespace WGP.LIGHTS
{
    /// <summary>
    /// Basic wall for the light manager.
    /// </summary>
    public class Wall
    {
        /// <summary>
        /// First point of the segment.
        /// </summary>
        public Vector2f Pt1 { get; set; }
        /// <summary>
        /// Second point of the segment.
        /// </summary>
        public Vector2f Pt2 { get; set; }
    }
}
