using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Tellez.Classes
{
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int DrawersNumber { get; set; }
        public string Material { get; set; }

        public Desk(int width, int depth, int drawerNumber, string material) 
        {
            Width = width;
            Depth = depth;
            DrawersNumber = drawerNumber;
            Material = material;
        }
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
