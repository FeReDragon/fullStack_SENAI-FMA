
class Conta {
  constructor(codigo) {
    this.codigo = codigo;
    this.saldo = 0.0;
  }
  
  getCodigo() {
    return console.log('Codigo: ', this.codigo);
  }

  getSaldo() {
    return console.log('Saldo: ', this.saldo);
  }

  setDeposito(valor) {
    this.saldo += valor;
  }
}

var conta = new Conta(1234);

conta.getSaldo();
conta.setDeposito(1000);
conta.saldo = 5000; // tenta mudar o saldo
conta.getSaldo();