using System.Drawing;

namespace DestroyerFarewellCard.Cards
{
    public class KasparasCard : AbstractCard
    {
        private static readonly string MESSAGE = "It was pleasure working with you. We haven't work for long, but it was nice. Best of Luck in your next job.";
        private static readonly string IMAGE_URI = "./Images/GoodLuck.jpg";
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
            return Order.ImageFirst;
        }
    }
}
