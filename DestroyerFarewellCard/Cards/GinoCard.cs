using System.Drawing;

namespace DestroyerFarewellCard.Cards
{
    public class GinoCard : AbstractCard
    {
        private static readonly string MESSAGE = "======================================================================================================================\n" +
            "\tLukas - Wishing you only the best on your new adventure. \n" +
            "\tMay the “Rekt” gods shine upon The Destroyer with great favour and fortune :D\n" +
            "======================================================================================================================";
        
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
