using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class main {
  public static void Main (string[] args) {
    StreamWriter x;

    string usuarioTxt = "usuario.txt";

    x = File.CreateText(usuarioTxt);

    x.WriteLine();

    Criptomoeda BTC = new Criptomoeda("BTC", 250.00000);
    Criptomoeda ETH = new Criptomoeda("BTC", 160.0000);
    Criptomoeda ADA = new Criptomoeda("BTC", 14.00);

  }
}