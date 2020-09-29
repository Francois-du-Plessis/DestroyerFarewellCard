using System.Drawing;

namespace DestroyerFarewellCard.Cards
{
    public class ExampleCard : AbstractCard
    {
        private static readonly string MESSAGE = "All the best Lukas with your future endevours";
        
        private static readonly string IMAGE_URI = "./Images/test_image.png"; //Put image in Images folder and make sure 
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
