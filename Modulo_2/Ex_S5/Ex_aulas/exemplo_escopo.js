
//variavel global
//var idade = 17;
//let idade = 17;
//const idade = 17;

function retornarMsg(msgRetorno) {
  console.log(msg, idade);
}

function calcularIdade() {
  //variavel local à calcularIdade
  
  var msg = 'Usuário é maior de idade';
  //let msg = 'Usuário é maior de idade';

  if (idade >= 18) {
    msg = 'Usuário é maior de idade';
    //retornarMsg(msg);
  } else {
    msg = 'Usuário é menor de idade';
    //retornarMsg(msg);
  }
  const idade = 17;

  console.log(msg);
}


calcularIdade();
