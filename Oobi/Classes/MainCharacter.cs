using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Oobi.Classes
{
    class MainCharacter
    {
        public int lives { set; get; }
        public Vector2 position { set; get; }
        public Vector2 velc { set; get; }

        public MainCharacter(Vector2 p, Vector2 v, int l = 0)
        {
            lives = l;
            position = p;
            velc = v;
        }
    }
}
