import { getNomes, filtrarNomesComA, filtrarNomesSemA, filtrarNomesComMenosDeSeisLetras } from './nomes.js';

let nomes = [];

function mostrarNomes(nomesFiltrados, titulo) {
    let divDados = document.getElementById('dados');
    divDados.innerHTML = '';
    let divSection = document.createElement('div');
    let h2Title = document.createElement('h2');
    h2Title.textContent = titulo;
    divSection.appendChild(h2Title);

    nomesFiltrados.forEach(item => {
        let divNomeRanking = document.createElement('div');
        divNomeRanking.classList.add('nome-ranking');
        divNomeRanking.textContent = `Nome: ${item.nome}, Rank: ${item.rank}`;
        divSection.appendChild(divNomeRanking);
    });

    divDados.appendChild(divSection);
}

// Obtendo a lista de nomes
getNomes()
    .then(response => {
        nomes = response;
        mostrarNomes(nomes, "Lista Original");
    })
    .catch(error => console.error('Erro:', error));

// Aplicando o filtro selecionado
document.getElementById('aplicarFiltro').addEventListener('click', () => {
    let filtro = document.getElementById('filtro').value;
    switch (filtro) {
        case 'original':
            mostrarNomes(nomes, "Lista Original");
            break;
        case 'invertida':
            mostrarNomes([...nomes].reverse(), "Lista Invertida");
            break;
        case 'comA':
            let nomesComA = filtrarNomesComA(nomes);
            mostrarNomes(nomesComA, "Nomes com a letra 'a'");
            break;
        case 'semA':
            let nomesSemA = filtrarNomesSemA(nomes);
            mostrarNomes(nomesSemA, "Nomes sem a letra 'a'");
            break;
        case 'menosDeSeis':
            let nomesComMenosDeSeisLetras = filtrarNomesComMenosDeSeisLetras(nomes);
            mostrarNomes(nomesComMenosDeSeisLetras, "Nomes com menos de 6 letras");
            break;
    }
});
