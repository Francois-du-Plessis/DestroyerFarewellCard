using System.Drawing;

namespace DestroyerFarewellCard.Cards
{
    public class FrancoisCard : AbstractCard
    {
        private static readonly string MESSAGE = "=======================================================================================================================\n" +
            "\tWat gaan ek doen sonder my programmer-to-business translator!?\n" +
            "\tNou gaan niemand my verstaan nie :D\n" +
            "\tSterkte by you nuwe werk, eks doodseker jy gaan baie vinnig 'n legacy (in die goeie sin van die woord) daar ook begin!\n" +
            "\tDankie vir die mentorskap en al 'sanity checks' wat baie bygedra het tot my groei in my loopbaan.\n" +
            "=======================================================================================================================";
        
        private static readonly string IMAGE_URI = "./Images/Mahhhh!!!.jpg"; //Put image in Images folder and make sure 
                                                                              //its build properties are set to copy to output

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
