using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace Gang_Garrison_2
{
     class Menu
     {
          /// <summary>
          /// List of Possible States The Menu Can Be In
          /// </summary>
          enum States{
               SPLASH = 0,
               MAIN_MENU,
               OPTIONS,
               CREDITS
          };

          private States MenuStates;
          private Splash splashScreen;


          private Texture2D menuBackground;

          public Menu(GraphicsDevice GraphicsDevice, ContentManager Content )
          {
               // Set the MenuState to Splash
               MenuStates = States.SPLASH;
               splashScreen = new Splash(GraphicsDevice, Content);
          }

          public void LoadResources(ContentManager Content)
          {
               // load the menu background
               menuBackground = Content.Load<Texture2D>("menuBackground");
          }

          public void Update(GameTime gameTime)
          {

               switch (MenuStates)
               {
                    // the case of the splash screen
                    case States.SPLASH:
                         splashScreen.Update(gameTime);
                         if (splashScreen.IsFinished)
                              MenuStates = States.MAIN_MENU;
                         break;
                    case States.MAIN_MENU:
                         // update mainMenu code
                         break;
                    case States.OPTIONS:
                         // update the options code
                         break;
                    case States.CREDITS:
                         // update the credits code
                         break;

               }


          }

          public void Draw(SpriteBatch spriteBatch)
          {
               switch (MenuStates)
               { 
                    case States.SPLASH:
                         splashScreen.Draw(spriteBatch);
                         break;
                    case States.MAIN_MENU:
                         spriteBatch.Draw(menuBackground, new Rectangle(0,0,800,480), Color.White);
                         break;
                    default:
                         throw new Exception("State Not Accounted For!");
               }
          }
     }
}
