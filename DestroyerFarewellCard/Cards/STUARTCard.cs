using System.Drawing;

namespace DestroyerFarewellCard.Cards
{
    public class STUARTCard : AbstractCard
    {
        private static readonly string MESSAGE = "I'll miss all the memes and inside jokes, who will have comments for us now??";

        private static readonly string IMAGE_URI = "./Images/rick_morty.png";

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
