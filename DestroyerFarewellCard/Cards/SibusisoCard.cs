using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DestroyerFarewellCard.Cards
{
    class SibusisoCard : AbstractCard
    {
        private static string MESSAGE = "Hey man, I have a comment too - wishing you all the best for the future. Thanks for all the mentoring, memes and hikes over the years";
        private static string IMAGE_URI = "./Images/mission.png";
        public override string GetCardMessage()
        {
            return MESSAGE;
        }

        public override Bitmap GetImage()
        {
            return GetBitmapFromUri(IMAGE_URI);
        }
    }
}
