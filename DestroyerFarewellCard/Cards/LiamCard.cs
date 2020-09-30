using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DestroyerFarewellCard.Cards
{
    class LiamCard : AbstractCard
    {
        private static readonly string MESSAGE = "=======================================================================================================================\n" +
                    "\t Hey Lukas, its been a priveledge getting led, trained, and mentored by you. \n" +
                    "\t Thanks for not rekting me too much!  \n" +
                    "\t Hope you keep !!DESTROYING!! at your new place     \n" +
                    "\t ALL THE BEST DOOD!  \n" +
                    "=======================================================================================================================";
       
        private static readonly string IMAGE_URI = "./Images/Lukas_and_friend.png";

        public override string GetCardMessage()
        {
            return MESSAGE;
        }

        public override Bitmap GetImage()
        {
            return GetBitmapFromUri(IMAGE_URI);
        }

        public override Order GetOrder()
        {
            return Order.MessageFirst;
        }
    }
}
