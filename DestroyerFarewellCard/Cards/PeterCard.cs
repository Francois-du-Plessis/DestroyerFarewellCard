using System.Drawing;

namespace DestroyerFarewellCard.Cards
{
    public class PeterCard : AbstractCard
    {
        private static readonly string MESSAGE = "Lukas, dude all the of the best with the new chapter ahead, and congrats on becoming a dad as well! From the short time I had to get to know you, I can see how much you care about those around you, which will be highly valued in your new role. Blessings, Peter.";
        
        private static readonly string IMAGE_URI = ""; //Put image in Images folder and make sure 
                                                                              //its build properties are set to copy to output

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
