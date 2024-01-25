using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosPractica
{
    internal class PrintDelegate
    {
        //public delegate void MyDel(string text,int opt);
        //public MyDel Print;


        ////ImprimirCartasAleatorias
        //public void GenerateCard()
        //{
        //    Random rnd = new Random();

        //    List<string> cards = new List<string>() { "A", "J","Q","K"};
        //    foreach (string card in cards)
        //    {
        //        rnd.Next(1,10);
        //        Print($"{card} {rnd}", 0);
        //    }
        //}
        //public void GenerateCard2()
        //{
        //    Random rnd = new Random();

        //    List<string> cards = new List<string>() { "A", "J", "Q", "K" };
        //    foreach (string card in cards)
        //    {
        //        rnd.Next(1, 10);
        //        Print($"{card} {rnd} Holla", 1);
        //    }
        //}
        public Action<string, int> print;

        public void GenerateCard()
        {
            Random rnd = new Random();

            List<string> cards = new List<string>() { "A", "J", "Q", "K" };
            foreach (string card in cards)
            {
                rnd.Next(1, 10);
               print($"{card} {rnd}", 0);
            }
        }
        public void GenerateCard2()
        {
            Random rnd = new Random();

            List<string> cards = new List<string>() { "A", "J", "Q", "K" };
            foreach (string card in cards)
            {
                rnd.Next(1, 10);
                print($"{card} {rnd} Holla", 1);
            }
        }

    }
}
