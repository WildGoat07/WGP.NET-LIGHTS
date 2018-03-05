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
    /// Main light manager. Used to create and handle lights.
    /// </summary>
    public class LightsManager
    {
        private List<Light> Lights { get; set; }
        private List<Wall> Walls { get; set; }
        /// <summary>
        /// Required for the texture rendering. The texture should be drawn on top of the scene with a multiplicative blendmode.
        /// </summary>
        public RenderTexture Target { get; set; }
        /// <summary>
        /// The view of the window, if different from the textures.
        /// </summary>
        public View View { get; set; }
        /// <summary>
        /// The shadows / ambient color.
        /// </summary>
        public Color ShadowsColor { get; set; }
        /// <summary>
        /// Constructor.
        /// </summary>
        public LightsManager()
        {
            Lights = new List<Light>();
            Walls = new List<Wall>();
            Target = null;
            View = null;
            ShadowsColor = Color.Black;
        }
        /// <summary>
        /// Adds a new light.
        /// </summary>
        /// <returns>New light.</returns>
        public Light NewLight()
        {
            Light tmp = new Light();
            Lights.Add(tmp);
            return tmp;
        }
        /// <summary>
        /// Adds a new wall.
        /// </summary>
        /// <returns>New wall.</returns>
        public Wall NewWall()
        {
            Wall tmp = new Wall();
            Walls.Add(tmp);
            return tmp;
        }
        /// <summary>
        /// Updates the textures to match the lights and walls.
        /// </summary>
        public void UpdateTargets()
        {
            if (Target != null)
            {
                if (View != null)
                    Target.SetView(View);
                Target.Clear(ShadowsColor);
                foreach (var light in Lights)
                {
                    List<Vertex> vertices = new List<Vertex>();
                    vertices.Add(new Vertex(light.Position, light.Color));
                    for (var i = (light.Angle - light.Field / 2); i < (light.Angle + light.Field / 2); i += Angle.FromDegrees(1 / light.Precision))
                    {
                        Vertex vertex = new Vertex();
                        vertex.Position = light.Position + i.GenerateVector(light.Radius);
                        vertex.Color = Color.Black;
                        vertices.Add(vertex);
                    }
                    {
                        Vertex vertex = new Vertex();
                        vertex.Position = light.Position + (light.Angle + light.Field / 2).GenerateVector(light.Radius);
                        vertex.Color = Color.Black;
                        vertices.Add(vertex);
                    }
                    Target.Draw(vertices.ToArray(), PrimitiveType.TrianglesFan, new RenderStates(BlendMode.Add));
                }
                Target.Display();
            }
        }
    }
}
