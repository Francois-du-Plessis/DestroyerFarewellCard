using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DestroyerFarewellCard.Cards
{
    class EVT : AbstractCard
    {
        private static readonly string MESSAGE = "*****************************\nI guess this means divorce :/\nSo sorry I'll need to find someone else with a house and a dog.\nGive my best to your wife!\n*****************************";
        private static readonly string IMAGE_URI = "./Images/aloha.jpg";
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
