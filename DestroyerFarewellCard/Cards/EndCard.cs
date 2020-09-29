using System.Drawing;

namespace DestroyerFarewellCard.Cards
{
    public class EndCard : AbstractCard
    {
        private static readonly string MESSAGE = "We've got a comment for yah! All the best dude!";
        private static readonly string IMAGE_URI = "./Images/Lukas_lookalike.png";

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
