﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace JumpThing
{
    class CoinSprite : Sprite
    {
        public CoinSprite(Texture2D newSpriteSheet, Texture2D newCollisionTxt, Vector2 newLocation) : base(newSpriteSheet, newCollisionTxt, newLocation)
        {
            spriteOrigin = new Vector2(0.5f, 0.5f);
            isColliding = true;

            animations = new List<List<Rectangle>>();
            animations.Add(new List<Rectangle>());
            animations[0].Add(new Rectangle(48, 48, 48, 48));
            animations[0].Add(new Rectangle(96, 48, 48, 48));
            animations[0].Add(new Rectangle(144, 48, 48, 48));
            animations[0].Add(new Rectangle(96, 48, 48, 48));
        }
    }
}
