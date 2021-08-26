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

    a.compraCriptomoeda(2);

    Console.WriteLine(a.Real);

    a.vendaCriptomoeda(3);

    Console.WriteLine(a.Real);
    Console.WriteLine(a.Cripto);

    

    

  }
}