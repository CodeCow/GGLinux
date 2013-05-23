using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace Gang_Garrison_2
{
     /// <summary>
     /// Handles the logic for the splash screen
     /// </summary>
     class Splash
     {
          private Texture2D faucetLogo;
          private Alarm testAlarm;
          private SoundEffect testMusic;
          private SoundEffectInstance testInstance;
          private Animation animationObject;
          private bool isFinished;

          /// <summary>
          /// Handles the initlization of the SplashObject
          /// </summary>
          public Splash(GraphicsDevice GraphicsDevice, ContentManager Content)
          {
               testAlarm = new Alarm(5.55f);
               testMusic = Content.Load<SoundEffect>("faucetmusic");
               testInstance = testMusic.CreateInstance();
               testInstance.IsLooped = false;
               testMusic.Play(0.1f, 0.0f, 0.0f);
               faucetLogo = Content.Load<Texture2D>("FaucetLogoS_SpriteSheet_strip22.png");
               animationObject = new Animation(new Vector2(60, 41), 0f, 1f, 0f, false);
               animationObject.Load(GraphicsDevice, Content, "FaucetLogoS_SpriteSheet_strip22.png", 22, 8);
          }

          /// <summary>
          /// Updates The Animation
          /// </summary>
          /// <param name="gameTime"></param>
          public void Update(GameTime gameTime)
          {
               testAlarm.UpdateAlarm((float)gameTime.ElapsedGameTime.TotalSeconds);

               if (testAlarm.IsFinished)
               {
                    animationObject.UpdateFrame((float)gameTime.ElapsedGameTime.TotalSeconds);
               }   
               if (animationObject.IsFinished)
               {
                    isFinished = true;
                    
                    testInstance.Stop();
                    
               }
          }

          /// <summary>
          /// Draws the Animated Splash Icon 
          /// </summary>
          /// <param name="spriteBatch"></param>
          public void Draw(SpriteBatch spriteBatch)
          {
               animationObject.DrawFrame(spriteBatch, new Vector2(800 / 2, 480 / 2));
          }

          public bool IsFinished
          {
               get { return isFinished;}
          }

          ~Splash()
          {
               testInstance.Dispose();
               testMusic.Dispose();
          }
     }
}
