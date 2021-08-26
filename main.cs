using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program {
  public static void Main (string[] args) {
    StreamWriter x;

    string usuarioTxt = "usuario.txt"

    x = File.CreateText(usuarioTxt);

    x.WriteLine()

  }
}