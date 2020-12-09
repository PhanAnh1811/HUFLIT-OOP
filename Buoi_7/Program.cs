using System;
using System.Collections.Generic;
using System.Linq;

namespace Buoi_7
{
    class Program
    {
        static List<Manga> listMangas;
        static int n;

        public static void MainInput()
        {
            Console.WriteLine("Enter number of mangas : ");
            n = int.Parse(Console.ReadLine());
            listMangas = new List<Manga>(n);

            for (int i = 0; i < n; i++)
            {             
                int choice = int.Parse(Console.ReadLine());
                SwitchManga(choice);                
            }
        }

        public static void MainOutput()
        {
            foreach(var x in listMangas)
            {
                x.Output();
            }
        }

        public static void SwitchManga(int i)
        {
            switch (i)
            {
                case 0:
                    ChildrenManga childrenManga = new ChildrenManga();
                    childrenManga.Input();
                    listMangas.Add(childrenManga);
                    break;
                case 1:
                    ComedyManga comedyManga = new ComedyManga();
                    comedyManga.Input();
                    listMangas.Add(comedyManga);
                    break;
                default:
                    ActionManga actionManga = new ActionManga();
                    actionManga.Input();
                    listMangas.Add(actionManga);
                    break;
            }
        }

        public static void GetMangaAt(int pos)
        {
            listMangas[pos].Output();
        }

        public static void insertChildMangaAt(int pos)
        {
            ChildrenManga children = new ChildrenManga("TN001", "Truyện con heo", "Phan anh", 10, 10);
            listMangas.Insert(pos, children);
        }

        public static int Sum(int pos)
        {
            return listMangas[pos].Amount;
        }

        public static void  SortDescByAmount()
        {
            listMangas.Sort((x, y) => x.Amount.CompareTo(y.Amount));
            listMangas.Reverse();
        }

        public static void ExtraAmount(string _id)
        {
            foreach(var x in listMangas)
            {
                if(x.Id == _id)
                {
                    x.Amount *= 2;
                }
            }
        }

        public static void RemoveAt(int pos)
        {
            listMangas.RemoveAt(pos);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //MainInput();
            //MainOutput();
            listMangas = new List<Manga>(9);
            listMangas.Add(new ChildrenManga("TN001", "Thieu nhi", "vudang", 10, 20));
            listMangas.Add(new ChildrenManga("TN002", "Thieu nhi", "vudang", 20, 20));
            listMangas.Add(new ChildrenManga("TN003", "Thieu nhi", "vudang", 30, 20));
            listMangas.Add(new ComedyManga("TT001", "Tieu Thuyet", "vudang", 40, "ngon tinh"));
            listMangas.Add(new ComedyManga("TT002", "Tieu Thuyet", "vudang", 50, "ngon tinh"));
            listMangas.Add(new ComedyManga("TT003", "Tieu Thuyet", "vudang", 50, "ngon tinh"));
            listMangas.Add(new ActionManga("HD001", "Hanh dong", "vudang", 10, 9));
            listMangas.Add(new ActionManga("HD002", "Hanh dong", "vudang", 40, 9));
            listMangas.Add(new ActionManga("HD003", "Hanh dong", "vudang", 30, 9));

            //GetMangaAt(0);
            //GetMangaAt(2);
            //GetMangaAt(5);

            //insertChildMangaAt(2);
            //insertChildMangaAt(3);

            //GetMangaAt(2);
            //GetMangaAt(3);

            //int mySum = Sum(1) + Sum(2) + Sum(3);
            //Console.WriteLine("Number of mangas : " + mySum);

            //SortDescByAmount();
            //MainOutput();

            //ExtraAmount("TN001");
            //GetMangaAt(0);

            //RemoveAt(listMangas.Count - 1);
            //RemoveAt(listMangas.Count - 2);
            //MainOutput();

            for(int i = 0; i < listMangas.Count; i++)
            {
                listMangas.RemoveAt(i);

            }

            MainOutput();



        }
    }
}
