using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Tapia
{
    internal class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        public DesktopMaterial Material { get; set; }

        // Constants for width and depth constraints
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;
        public const int MIN_DRAWERS = 0;
        public const int MAX_DRAWERS = 7;

        // Setting up constructors
        public Desk() { }

        public Desk(int width, int depth, int numDrawers, DesktopMaterial material)
        {
            Width = width;
            Depth = depth;
            NumDrawers = numDrawers;
            Material = material;
        }


        // Enumerated type for desktop materials
        

       
    }
    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }

}
