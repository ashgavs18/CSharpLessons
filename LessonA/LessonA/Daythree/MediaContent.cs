using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Daythree
{
    internal class MediaContent
    {
        public  virtual void StartPlayingContent()
        {
            Console.WriteLine("start");
        }
        public virtual void StopPlayingContent()
        {
            Console.WriteLine("stop");
        }
        public virtual void PausePlayingContent()
        {
            Console.WriteLine("pause");
        }
        public virtual void ContinuePlayingContent()
        {
            Console.WriteLine("continue");
        }

    }
    // end of mediacontent class
    internal class AudioContent : MediaContent
    {
        // parent method should be virtual if the method of the parent should be override in the child class
        public override  sealed void StartPlayingContent() 
        {
            Console.WriteLine("start form audiocontent");
        }

    }
    // end of audiocontent class
    internal class VideoContent : AudioContent
    {
        // sealed is to stop override
        //public override  void StartPlayingContent()
        //{
        //    Console.WriteLine("start form videocontent");
        //}


    }
    // end of vidoecontent class
    internal class MediaTester
    {
        public static void TestOne()
        {

        }
    }
    // end of mediatester class
}
// even from the base class i.e system.object can restrict override
