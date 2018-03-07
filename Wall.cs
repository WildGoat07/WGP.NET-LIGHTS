using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGP.LIGHTS
{
    /// <summary>
    /// A wall for the light manager.
    /// </summary>
    public class Wall
    {
        /// <summary>
        /// The line describing the wall.
        /// </summary>
        public Segment Body { get; set; }
        internal Wall() { }
    }
}
