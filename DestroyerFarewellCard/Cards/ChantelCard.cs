using System.Drawing;

namespace DestroyerFarewellCard.Cards
{
    public class ChantelCard : AbstractCard
    {
        private static readonly string MESSAGE = "======================================================================================================================\n" +
            "\tSo saaaaaaaaaaaaaaaaad :( It's been a long while and quite a journey from the little office we first worked in together.\n" +
            "\tGoing to miss not having you around.\n" +
            "\tWishing you all the very best. <3\n" +
            "======================================================================================================================";
        
        private static readonly string IMAGE_URI = "./Images/chantel_heart.png"; //Put image in Images folder and make sure 
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
