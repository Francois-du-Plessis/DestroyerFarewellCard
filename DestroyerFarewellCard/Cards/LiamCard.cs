using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DestroyerFarewellCard.Cards
{
    class LiamCard : AbstractCard
    {
        private static readonly string MESSAGE = "Hey Lukas, its been a priveledge getting led, trained, and mentored by you. Thanks for not rekting me too much! Hope you keep destroying at your new place - ALL THE BEST DOOD!";
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
