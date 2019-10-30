using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeTest
{
    class SuperSmartTvController
    {
        static void Main(string[] args)
        {
            MySuperSmartTV myTv = new MySuperSmartTV();
                        
            Console.WriteLine("Select A source to get TV Guide and Play");
            Console.WriteLine("1. Local Cable TV\n2. Local Dish TV\n3. IP TV");

            ConsoleKeyInfo input = Console.ReadKey();

            // Let us see what user has selected and select the video source accrodingly
            switch (input.KeyChar)
            {
                case '1':
                    myTv.VideoSource = new LocalCabelTv();
                    break;

                case '2':
                    myTv.VideoSource = new LocalDishTv();
                    break;

                case '3':
                    myTv.VideoSource = new IPTvService();
                    break;                
            }

            Console.WriteLine(); //some whitespace on output for readability

            //Let us show the TV guide from selected source
            myTv.ShowTvGuide();

            //Let us now play the selected TV source.
            myTv.PlayTV();

            Console.WriteLine(); //some whitespace on output for readability
            Console.ReadKey();
        }
    }
}
