using System.Drawing;

namespace DestroyerFarewellCard.Cards
{
    public class TitleCard : AbstractCard
    {
        private static readonly string MESSAGE = "";
        private static readonly string IMAGE_URI = "./Images/Title_Image.png";

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
