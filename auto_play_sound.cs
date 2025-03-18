using System;
using System.IO;
using System.Media;


namespace auto_playsound
{
    public class auto_play_sound
    {
        // constructor 
        public auto_play_sound()
        {
            // getting the app full location
            string full_location = AppDomain.CurrentDomain.BaseDirectory;
            
            // replace bin\debug\
            string new_path = full_location.Replace("bin\\Debug\\","");

            // combne the paths
            string full_path = Path.Combine(new_path, "greeting.wav");

            // try and catch to play the audio
            try
            {
                //making use of using functions
                using (SoundPlayer play = new SoundPlayer (full_path))  
                {
                    // play the file 
                    play.PlaySync();
                }//end of using functions
            }
            catch (Exception error) { Console.WriteLine(error.Message);}// end of catch

        }// end of constructor
    }// end of class 
}//end of namespace