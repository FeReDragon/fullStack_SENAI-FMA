class Conta {
  constructor(codigo) {
    this.codigo = codigo;
    this.saldo = 0.0;
  }

  deposita(valor) {
    this.saldo += valor;
    this.imprime("Depositou R$ " + valor);
  };

  mostraCodigo() {
    this.imprime("Codigo: " + this.codigo);
  };

  mostraSaldo() {
    this.imprime("Saldo: " + this.saldo);
  };

  imprime(msg) {
    console.log(msg);
  }
}

class ContaCorrente extends Conta {
  constructor(codigo, dataAbertura) {
    super(codigo);
    this.dataAbertura = dataAbertura;
  }

  abertura() {
    console.log('Conta Corrente aberta em: ', this.dataAbertura);
  }
}

var cc = new ContaCorrente(1234, '01/01/2020');
cc.abertura();
cc.mostraSaldo();
cc.deposita(1000);
cc.mostraSaldo();
