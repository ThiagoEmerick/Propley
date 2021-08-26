using System;

class Carteira{
  private double _real;
  private double _criptomoeda;

  public Carteira(){

  }

  public double Real{
    get { return _real; }
    set { _real = value; } 
  }

  public double Cripto{
    get { return _criptomoeda; }
    set { _criptomoeda = value; } 
  }

  public double realizarDeposito(double real){
    this._real += real;
    return real;
  }

  public double realizarSaque(double real){
    this._real -= real;
    return real;
  }

  public double compraCriptomoeda(double cripto){
    this._real -= (cripto*250.00000); 
    this._criptomoeda += cripto;
    
    return cripto;
  }

}