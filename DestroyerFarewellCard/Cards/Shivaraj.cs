using System.Drawing;

namespace DestroyerFarewellCard.Cards
{
    public class ShivarajCard : AbstractCard
    {
        private static readonly string MESSAGE = "All the best Lukas(God father of passport).Your professional behaviour and hard work will definitely serve as an inspiration to all of us";
        
        private static readonly string IMAGE_URI = "./Images/Shivaraj.png"; //Put image in Images folder and make sure 
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
