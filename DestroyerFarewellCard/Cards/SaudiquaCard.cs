using System.Drawing;

namespace DestroyerFarewellCard.Cards
{
    public class SaudiquaCard : AbstractCard
    {
        private static readonly string MESSAGE = "======================================================================================================================\n" +
            "\tWishing you all the best on your new adventure Lukas!\n" +
            "\tThanks for all the good memories and laughs, I can’t believe you’re leaving me behind with these crazies.\n" +
            "\tThe office is going to be empty without you… or will it??\n" +
            "\tTsek!\n" +
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
