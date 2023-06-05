class Animal {
  constructor(tipo, nome, tamanho, cor, idade) {
    this.tipo = tipo;
    this.nome = nome;
    this.tamanho = tamanho;
    this.cor = cor;
    this.idade = idade;
  }

  dormir() {
    //var msg = this.nome + ' está dormindo..';
    var msg = `${this.nome} está dormindo..`;
    //console.log(this.nome, ' está dormindo..');

    console.log(msg);
  }

  comer(comida) {
    console.log(`${this.nome} está comendo ${comida}..`);
  }

  static respirar() {
    console.log('O animal está respirando..');
  }
}

//instancias da classe Animal
var lulu = new Animal('cachorro', 'Lulu', 'pequeno', 'preta', '14');
var tom = new Animal('gato', 'Tom', 'medio', 'branca', '6');

//metodos da instancia
lulu.dormir();
tom.comer('peixe');

//metodo da classe (esta)
Animal.respirar();