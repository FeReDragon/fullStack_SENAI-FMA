function bissexto(ano) {
  /*
  console.log('mod 400', ano % 400);
  if (ano % 400 === 0) {
    console.log('Ano bissexto');
    return;
  }

  console.log('mod 4', ano % 4);
  console.log('mod 100', ano % 100);
  if ((ano % 4 === 0) && (ano % 100 !== 0)) {
    console.log('Ano bissexto');
    return;
  }
  */

  /*
  if ((ano % 400 === 0) || ((ano % 4 === 0) && (ano % 100 !== 0))) {
    console.log('Ano bissexto');
  } else {
    console.log('Ano não bissexto');
  }
  */

  //var msg = ((ano % 400 === 0) || ((ano % 4 === 0) && (ano % 100 !== 0))) ? 'Ano bissexto' : 'Ano não bissexto';

  //ternario
  //var msg = expressao ? 'se for true' : 'se for falso';
  
  //comparação
  //var msg = 1 !== '1' ? 'verdadeiro' : 'falso';
}

bissexto(1996);