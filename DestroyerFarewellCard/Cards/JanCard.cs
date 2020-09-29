using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DestroyerFarewellCard.Cards
{
    public class JanCard : AbstractCard
    {
        private static readonly string MESSAGE = "*****************************" +
            "\nHey Lukas, gonna miss you in the work place dude." +
            "\nIt won't be same and definitely going to miss the 'Sure Jan' gifs alot :)." +
            "\nAll the best for the new work endeavours. It's been an honour to work with you." +
            "\nHappy Destruction Destroyer." +
            "\n*****************************";
        private static readonly string IMAGE_URI = "./Images/Metallica.png";

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
