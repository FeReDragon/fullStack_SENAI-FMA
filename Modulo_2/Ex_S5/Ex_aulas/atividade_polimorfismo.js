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

class ContaPoupanca extends Conta {
  constructor(codigo, juros) {
    super(codigo);
    this.juros = juros;
  }

  deposita(valor) {
    let valorAtualizado = valor * (1 + this.juros);
    this.saldo += valorAtualizado;
    this.imprime("Valor Atualizado R$ " + valorAtualizado);
  };
}

var cp = new ContaPoupanca(1234, 0.005);
cp.mostraSaldo();
cp.deposita(100);
