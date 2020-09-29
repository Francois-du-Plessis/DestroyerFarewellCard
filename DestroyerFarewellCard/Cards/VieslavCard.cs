using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DestroyerFarewellCard.Cards
{
    class VieslavCard : AbstractCard
    {
        private static readonly string MESSAGE = "Termination of stuff will not be the same anymore. Hopefully, new challenges you face will be interesting and fun. Do you thing, Destroyer. All the best dude.";

        private static readonly string IMAGE_URI = "./Images/VL-image.png";

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
