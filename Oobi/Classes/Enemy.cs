﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Oobi.Classes
{
    class Enemy
    {
        public int lives { set; get; }
        public Vector2 position { set; get; }
        public Vector2 velc { set; get; }
        public int type { set; get; }

        public Enemy(int t, Vector2 v, Vector2 p, int l = 1)
        {
            lives = l;
            position = p;
            velc = v;
            type = t;
        }

        public void Move(GameTime gameTime)
        {
            position += velc * (float)gameTime.ElapsedGameTime.TotalSeconds;
        }
    }
}
