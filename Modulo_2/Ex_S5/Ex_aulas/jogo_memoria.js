var inputAberto;
var segundosContador = 0;
var minutosContador = 0;
var contadorCronometro;
var selecionadosCorretos = 0;

function selecionar(cardId) {
  let cardSelecionado = document.getElementById(cardId);
  let inputSelecionado = cardSelecionado.children[0];

  inputSelecionado.classList.add('show');

  if (!inputAberto) {
    inputAberto = inputSelecionado;
  } else if (parseInt(inputAberto.value) !== parseInt(inputSelecionado.value)) {
    setTimeout(() => {
      inputAberto.classList.remove('show');
      inputSelecionado.classList.remove('show');
      inputAberto = null;
    }, 1000);
  } else {
    inputAberto = null;
    selecionadosCorretos++

    if (selecionadosCorretos === 6) {
      window.alert('Você ganhou!');
      pausar();
    }
  }
}

function iniciar() {
  let segundosSpan = document.getElementById('segundos');
  let minutosSpan = document.getElementById('minutos');

  contadorCronometro = setInterval(() => {
    if (segundosContador == 59) {
      segundosContador = 0;
      minutosContador++;
    } else {
      segundosContador++;
    }
    segundosSpan.innerHTML = segundosContador;
    minutosSpan.innerHTML = minutosContador;
  }, 1000);
}

function pausar() {
  clearInterval(contadorCronometro);
}

function reiniciar() {
  let segundosSpan = document.getElementById('segundos');
  let minutosSpan = document.getElementById('minutos');

  segundosContador = 0;
  minutosContador = 0;
  
  segundosSpan.innerHTML = '';
  minutosSpan.innerHTML = '';
}