﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace JumpThing
{
    class PlatformSprite : Sprite
    {
        public PlatformSprite(Texture2D newSpriteSheet, Texture2D newCollisionTxt, Vector2 newLocation) : base(newSpriteSheet, newCollisionTxt, newLocation)
        {
            spriteOrigin = new Vector2(0.5f, 0f);
            isColliding = true;

            animations = new List<List<Rectangle>>();
            animations.Add(new List<Rectangle>());
            animations[0].Add(new Rectangle(0, 0, 96, 32));
        }
    }
}
