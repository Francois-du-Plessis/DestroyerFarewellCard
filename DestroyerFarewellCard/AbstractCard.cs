using System.Drawing;
using System.IO;

namespace DestroyerFarewellCard
{
    public abstract class AbstractCard
    {
        public AbstractCard() { }

        public abstract Bitmap GetImage();

        public abstract string GetCardMessage();

        public virtual Order GetOrder()
        {
            return Order.MessageFirst;
        }

        protected Bitmap GetBitmapFromUri(string uri)
        {
            if(!File.Exists(uri))
            {
                return null;
            }

            return new Bitmap(uri);
        }
    }
}
