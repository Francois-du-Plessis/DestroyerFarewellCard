﻿using DestroyerFarewellCard.Cards;
using System;
using System.Drawing;
using System.Linq;

namespace DestroyerFarewellCard
{
    class Program
    {
        private static readonly int SECONDS_BETWEEN_CARDS = 8;

        static void Main(string[] args)
        {
            WriteCard(typeof(TitleCard));
            WriteCards();
            WriteCard(typeof(EndCard));
        }

        private static void WriteCards()
        {
            var type = typeof(AbstractCard);

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsAbstract && p != typeof(TitleCard) && p != typeof(EndCard));

            foreach (var currentCardType in types)
            {
                WriteCard(currentCardType);
            }
        }

        private static void WriteCard(Type cardType)
        {
            var currentCard = Activator.CreateInstance(cardType) as AbstractCard;

            switch (currentCard.GetOrder())
            {
                case Order.MessageFirst:
                    WriteMessage(currentCard);
                    WriteImage(currentCard);
                    break;
                case Order.ImageFirst:
                    WriteImage(currentCard);
                    WriteMessage(currentCard);
                    break;
                default:
                    throw new Exception($"Unexpected Order {currentCard.GetOrder()}");
            }

            System.Threading.Thread.Sleep(SECONDS_BETWEEN_CARDS * 1000);
            Console.Clear();
        }

        private static void WriteMessage(AbstractCard card)
        {
            Console.WriteLine(card.GetCardMessage());
            WriteAuthor(card);
        }

        private static void WriteImage(AbstractCard card)
        {
            var image = card.GetImage();

            if (image != null)
            {
                ImageDrawHelper.ConsoleWriteImage(image);
            }
        }

        private static void WriteAuthor(AbstractCard card)
        {
            if(card is TitleCard || card is EndCard)
            {
                return;
            }

            var author = card.GetType().Name;

            var cardIndex = author.LastIndexOf("Card");
            if (cardIndex > -1)
            {
                author = author.Remove(cardIndex, 4);
            }

            Console.WriteLine($"\t\t - {author}");
        }

    }
}
