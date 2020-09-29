using System.Drawing;

namespace DestroyerFarewellCard.Cards
{
    public class KaanitaCard : AbstractCard
    {
        private static readonly string MESSAGE = "======================================================================================================================\n" +
            "\tJust a note to say that while you might move onto a new bright venture you will be deeply missed.\n" +
            "\tMay luck and success always be with you!!\n" +
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
