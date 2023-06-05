const tabuleiroJogo = document.getElementById('tabuleiro-jogo');
const cartas = [...Array(16).keys()].map(n => n % 8 + 1);
let cartasSelecionadas = [];
let cartasCombinadas = [];

function embaralharCartas(cartas) {
    for (let i = cartas.length - 1; i > 0; i--) {
        let j = Math.floor(Math.random() * (i + 1));
        [cartas[i], cartas[j]] = [cartas[j], cartas[i]];
    }
    return cartas;
}

function verificarCombinacao() {
    if (cartasSelecionadas[0].innerText === cartasSelecionadas[1].innerText) {
        cartasSelecionadas.forEach(carta => {
            carta.classList.add('combinada');
        });
        cartasCombinadas.push(...cartasSelecionadas);
        cartasSelecionadas = [];
        if (cartasCombinadas.length === 16) {
            alert('Parabéns, você venceu!');
        }
    } else {
        cartasSelecionadas.forEach(carta => {
            carta.classList.add('nao-combinada');
        });
        setTimeout(() => {
            cartasSelecionadas.forEach(carta => {
                carta.style.background = 'gray';
                carta.style.color = 'transparent';
                carta.classList.remove('virada', 'nao-combinada');
            });
            cartasSelecionadas = [];
        }, 1000);
    }
}

function criarTabuleiro(cartas) {
    embaralharCartas(cartas).forEach(carta => {
        let div = document.createElement('div');
        div.classList.add('carta');
        div.innerText = carta;
        div.addEventListener('click', function() {
            if (cartasSelecionadas.length < 2 && !cartasSelecionadas.includes(div) && !cartasCombinadas.includes(div)) {
                div.style.background = 'white';
                div.style.color = 'black';
                div.classList.add('virada');
                cartasSelecionadas.push(div);
                if (cartasSelecionadas.length == 2) {
                    verificarCombinacao();
                }
            }
        });
        tabuleiroJogo.appendChild(div);
    });
}

let nomeUsuario = prompt("Por favor, insira seu nome:");
if (nomeUsuario != null) {
    alert("Bem-vindo ao Jogo da Memória, " + nomeUsuario + "! Vamos começar!");
    criarTabuleiro(cartas);
    }
