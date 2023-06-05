
class Retangulo {
  constructor(altura, largura) {
    this.altura = altura;
    this.largura = largura;
  }

  //metodo referente a classe
  static areaStatic(altura, largura) {
    return altura * largura;
  }

  areaPublic(altura, largura) {
    return altura * largura;
  }
}

function start() {
  var retangulo = new Retangulo(2, 4);

  //console.log('console 1: ', retangulo.areaStatic(1, 2));
  console.log('console 2: ', Retangulo.areaStatic(2, 3));
  console.log('console 3: ', retangulo.areaPublic(3, 4));
  //console.log('console 4: ', Retangulo.areaPublic(4, 5));
}

start();
