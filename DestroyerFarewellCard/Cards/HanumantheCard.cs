using System.Drawing;

namespace DestroyerFarewellCard.Cards
{
    class HanumantheCard : AbstractCard
    {
        private static readonly string MESSAGE = "\n Wishing you all the best in the next step of your career!.\n Thank you for looking after us during our cape town visit\n";

        private static readonly string IMAGE_URI = "./Images/hanumanthe.png";       

        public override Bitmap GetImage()
        {
            return GetBitmapFromUri(IMAGE_URI);
        }


        public override string GetCardMessage()
        {
            return MESSAGE;
        }
    }
}
