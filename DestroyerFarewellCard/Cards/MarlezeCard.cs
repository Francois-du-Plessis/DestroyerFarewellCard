using System.Drawing;

namespace DestroyerFarewellCard.Cards
{
    public class MarlezeCard : AbstractCard
    {
        private static readonly string MESSAGE = "======================================================================================================================\n" +
            "\tWishing you all the best with your new role.\n" +
            "\tLook forward to you popping in for a cuppa and to say hi.\n" +
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
