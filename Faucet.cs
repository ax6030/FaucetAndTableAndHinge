using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaucetAndTableAndHinge
{
    internal class Faucet
    {
        public Faucet()
        {
            Table wine = new Table();
            Hinge book = new Hinge();
            wine.Set(book);
            book.Set(wine);
            book.garden.Lamp("back in");
            book.bulb *= 2;
            book.Lamp("minutes");
        }
    }
}
