﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using MilkShakeFramework.Core.Content;
using MilkShakeFramework.Core.Scenes;
using Microsoft.Xna.Framework;

namespace MilkShakeFramework.Render
{
    public class RenderManager : SceneComponent
    {
        private SpriteBatch mSpriteBatch;

        public RenderManager(Scene scene) : base(scene)
        {
            mSpriteBatch = new SpriteBatch(MilkShake.Graphics);
        }

        public void Draw(Vector2 position, Texture2D texture, int width, int height)
        {
            mSpriteBatch.Begin();
            mSpriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, width, height), new Rectangle(0,0, texture.Width, texture.Height), Color.White);
            mSpriteBatch.End();
        }
    }
}
