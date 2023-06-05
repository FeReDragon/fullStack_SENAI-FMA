function Conta(codigo) {
  this.codigo = codigo;
  var saldo = 0.0;

  this.deposita = function(valor) {
    saldo += valor;
    imprime("Depositou R$ " + valor);
  };
  this.mostraSaldo = function() {
    imprime("Saldo: " + saldo);
  };

  function imprime(msg) {
    console.log(msg);
  }
}

var conta = new Conta(1234);

conta.mostraSaldo();
conta.deposita(1000);
//conta.saldo = 5000
conta.mostraSaldo();