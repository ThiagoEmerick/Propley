class Criptomoeda : Dinheiro {

  string nomeMoeda;
  double valorMoeda;

  public Criptomoeda(string nomeMoeda, double valorMoeda){
    this.nomeMoeda = nomeMoeda;
    this.valorMoeda = valorMoeda;

  }

  BTC = new Criptomoeda(BTC,250.000.00);
  ETH = new Criptomoeda(BTC,16.000.00);
  ADA = new Criptomoeda(BTC,14.00);
}