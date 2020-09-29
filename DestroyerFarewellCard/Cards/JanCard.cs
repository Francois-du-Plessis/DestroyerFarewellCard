using System.Drawing;

namespace DestroyerFarewellCard.Cards
{
    public class JanCard : AbstractCard
    {
        private static readonly string MESSAGE = "*****************************\nHey Lukas, I'm really going to miss you in the work place dude. \nIt won't be same and I'm definitely going to miss the 'Sure Jan' gifs alot, but once this covid nonsense is over I'll see you in the new building :). \nAll the best for the new work endeavours. It's been an honour to work with you. /\nHappy destruction Destroyer.\n*****************************";

        private static readonly string IMAGE_URI = "./Images/Metallica.png"; //Put image in Images folder and make sure 
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
