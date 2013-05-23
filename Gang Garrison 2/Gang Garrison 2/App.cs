using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace Gang_Garrison_2
{
     /// <summary>
     /// Handles All Of The Game Logic
     /// </summary>
     class App 
     {
          private static bool isRunning;
          private static bool isExiting;
          private static bool isStarting;

          private Menu menuManager;

          private GraphicsDevice GraphicsDevice;
          private ContentManager Content;

          
          public App(Game1 game1)
          {
               this.GraphicsDevice = game1.GraphicsDevice;
               this.Content = game1.Content;
               isStarting = true;
          }

          public void Initalization()
          {
               menuManager = new Menu(GraphicsDevice, Content);
          }

          public void LoadResources()
          {
               if (isStarting)
               {
                    menuManager.LoadResources(Content);
               }
          }

          public void UpdateApplication(GameTime gameTime)
          {
               menuManager.Update(gameTime);
          }

          public void Draw(SpriteBatch spriteBatch)
          {
               menuManager.Draw(spriteBatch);
          }

          private void Cleanup()
          {
               menuManager = null;
          }

          ~App()
          {
               Cleanup();
          }

          



     }
}
