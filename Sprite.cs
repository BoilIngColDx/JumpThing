using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace JumpThing
{
    class Sprite
    {
        public Texture2D spriteSheestTxr, collisionTxr;
        public Vector2 spriteLocation, spriteVelocity, spriteOffset, collisionScale, collisionOffset;
        public bool isDead, isColliding, drawCollision, isFlipped;

        public int currentAnim, currentFrame;
        public float frameTime, frameCounter;
        public List<List<Rectangle>> animations;

        public Sprite(Texture2D newSpriteSheet, Texture2D newCollisionTxt, Vector2 newLocation)
        {
            spriteSheestTxr = newSpriteSheet;
            collisionTxr = newCollisionTxt;
            spriteLocation = newLocation;

            spriteOffset = new Vector2(0.5f, 0.5f);
            spriteVelocity = new Vector2(0f, 0f);
            collisionScale = new Vector2(1f, 1f);
            collisionOffset = new Vector2(0f, 0f);
            isColliding = false;
            drawCollision = false;
            currentAnim = 0;
            currentFrame = 0;
            frameTime = 0.5f;
            frameCounter = frameTime;

            animations = new List<List<Rectangle>>();

            animations.Add(new List<Rectangle>());
            animations[0].Add(new Rectangle(0, 0, 48, 48));
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            if (animations[currentFrame].Count > 1)
            {
                frameCounter -= (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (frameCounter <= 0)
                {
                    frameCounter = frameTime;
                    currentFrame++;
                    if (currentFrame >= animations[currentAnim].Count) currentFrame = 0;
                }
            }
            spriteBatch.Draw(
                spriteSheestTxr,
                new Rectangle(0, 0, 48, 48),
                animations[currentAnim][currentFrame],
                Color.White,
                0f,
                new Vector2(0, 0),
                SpriteEffects.None,
                1f
                );
        }


    }
}
