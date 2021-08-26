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

    Carteira a = new Carteira();

    a.realizarDeposito(500.00000);

    Console.WriteLine(a.Real);

    a.compraCriptomoeda(1);

    Console.WriteLine(a.Real);

    

    

  }
}