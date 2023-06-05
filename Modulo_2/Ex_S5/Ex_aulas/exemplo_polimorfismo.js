class Conta {
  constructor(codigo) {
    this.codigo = codigo;
    this.saldo = 0.0;
  }

  deposita(valor) {
    this.saldo += valor;
    this.imprime("Depositou R$ " + valor);
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

  imprime() {
    console.log("Conta corrente aberta em: " + this.dataAbertura);
  }
}

var cp = new ContaCorrente(134, '01/01/2021');

cp.imprime();