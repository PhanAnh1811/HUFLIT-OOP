using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_8
{
    public interface IFlower
    {
        string Buy();
    }

    public class OriginalFlower:IFlower
    {
        private string color;
        private string origin;

        public string Color { get => color; set => color = value; }
        public string Origin { get => origin; set => origin = value; }

        public OriginalFlower(string color,string origin)
        {
            this.Color = color;
            this.Origin = origin;
        }
        public string Buy()
        {
            string content = String.Format("Buy " + Color + " flowers have origin from " + Origin);
            return content;
        }
    }

    public class DecoratePaper : IFlower
    {
        private string type;
        private IFlower flower;

        public string Type { get => type; set => type = value; }
        public IFlower Flower { get => flower; set => flower = value; }

        public DecoratePaper(IFlower flower, string type)
        {
            this.Type = type;
            this.Flower = flower;
        }

        public string Buy()
        {
            string content = Flower.Buy();
            return content + " , decorate with type wrapping paper: " + this.Type;
        }
    }

    public class DecorateCards : IFlower
    {
        private string cards;
        private IFlower flower1;

        public string Cards { get => cards; set => cards = value; }
        public IFlower Flower1 { get => flower1; set => flower1 = value; }

        public DecorateCards(IFlower flower1, string cards)
        {
            this.Cards = cards;
            this.Flower1 = flower1;
        }

        public string Buy()
        {
            string content = Flower1.Buy();
            return content + " , with content: " + this.Cards;
        }
    }

}
