using System;

class Carteira{
  private double _real;
  private double _criptomoeda;
  public double aux;

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
    aux = _real;
    aux -= (cripto*250.00000);
    if(this.aux >= 0){
      this._real -= (cripto*250.00000);  
      this._criptomoeda += cripto;
    }
    else{
      Console.WriteLine("Saldo insuficiente");
    }
    return cripto;
  }

  public double vendaCriptomoeda(double cripto){
    if(_criptomoeda >= 0 && _criptomoeda > cripto){
    this._criptomoeda -= cripto;
    this._real += (cripto*250.00000);
    }
    else{
      Console.WriteLine("Saldo Insuficiente ou está tentando vender mais do que tem.");
      return _criptomoeda;
    }
    return cripto;
  }

}