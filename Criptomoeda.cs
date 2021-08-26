class Criptomoeda : Dinheiro {

  public Criptomoeda(string _nomeMoeda, double _valorMoeda) : base(_nomeMoeda, _valorMoeda){

  }

  Criptomoeda BTC = new Criptomoeda("BTC", 250.00000);
  Criptomoeda ETH = new Criptomoeda("BTC", 160.0000);
  Criptomoeda ADA = new Criptomoeda("BTC", 14.00);

  
}