using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bài 1*/
            #region Generic
            //Generator generator = new Generator();
            //generator.Show(246);
            //generator.Show('M');
            //generator.Show(25.5);
            //generator.Show("Phan Tuan Anh");
            #endregion

            /*Bài 2*/
            #region Design Pattern with Decorators
            //Origin
            OriginalFlower flower = new OriginalFlower("pink", "Holland");
            Console.WriteLine(flower.Buy());

            //Origin + Decorate paper
            OriginalFlower flower1 = new OriginalFlower("yellow", "France");
            DecoratePaper paper = new DecoratePaper(flower1, "blurred");
            Console.WriteLine(paper.Buy());

            //Origin + Decorate paper + Decorate cards
            OriginalFlower flower2 = new OriginalFlower("red", "England");
            DecoratePaper paper1 = new DecoratePaper(flower2, "blurred");
            DecorateCards cards = new DecorateCards(paper1, "happy birthday");
            Console.WriteLine(cards.Buy());
            #endregion

            Console.ReadKey();
        }
    }
}
