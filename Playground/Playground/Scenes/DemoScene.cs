﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MilkShakeFramework.Core.Scenes;
using MilkShakeFramework.Core.Game;
using Microsoft.Xna.Framework;
using MilkShakeFramework;
using MilkShakeFramework.Core.Game.Components.UI;

namespace Samples.Scenes
{
    public class DemoScene : Scene
    {
        public string Title { get; private set; }
        public string Description { get; private set; }

        private UILayer uiLayer;
        private Textfield _title;

        public DemoScene(string title, string description) : base()
        {
            Title = title;
            Description = description;

            AddNode(uiLayer = new UILayer(DrawMode.Post));

            uiLayer.AddNode(_title = new Textfield("Scenes//Global//DemoFont")
            {
                Text = Title,
                Color = Color.White
            });

            uiLayer.AddNode(_title = new Textfield("Scenes//Global//DemoFont")
            {
                Text = Description,
                Color = Color.White,
                Position = new Vector2(0, 50)
            });
        }
    }
}
