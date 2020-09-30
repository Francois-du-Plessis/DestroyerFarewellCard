using System.Drawing;

namespace DestroyerFarewellCard.Cards
{
    public class AnjeCard : AbstractCard
    {
        private static readonly string MESSAGE = "======================================================================================================================\n" +
            "\tSterkte met jou nuwe werk.\n" +
            "\tOns sal jou mis in die kantoor, maar wens jou alles van die beste toe.\n" +
            "\tMoenie worry nie, jy kan nogsteeds my life coach wees :D\n" +
            "\tJy moet lekker vakansie hou en lekker rus as jy kan :P\n" +
            "======================================================================================================================";
        
        private static readonly string IMAGE_URI = "./Images/anje-celebration.jpg"; //Put image in Images folder and make sure 
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
