using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gang_Garrison_2
{
     class Alarm
     {
          private float alarmDuration;
          private float totalElapsed;
          private bool isPlaying;
          private bool isPaused = false;
          private bool isFinished;

          public Alarm(float duration)
          {
               alarmDuration = duration;
               totalElapsed = 0;
               Start(); // the timer is now starting
          }

          public void UpdateAlarm(float elapsedTime)
          {
               if (isPaused || isPlaying == false)
               {
                    return; 
               }

               totalElapsed += elapsedTime;
               if (totalElapsed > alarmDuration)
               {
                    Stop();
               }

          }

          public void Start()
          {
               isPlaying = true;
          }

          public void Stop()
          {
               isPlaying = false;
               isPaused = false;
               isFinished = true;
          }

          public void Pause()
          {
               isPaused = true;
          }

          public void UnPause()
          {
               isPaused = false;
          }

         public bool IsFinished
         {
              get { return isFinished; }
         }
          ~Alarm()
          {
               alarmDuration = 0;
          }


            






     }
}
