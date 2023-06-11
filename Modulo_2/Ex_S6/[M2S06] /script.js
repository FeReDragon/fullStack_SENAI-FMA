// fetch("https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking")
//     .then(response => response.json())
//     .then(data => {
//         let divDados = document.getElementById('dados');
//         data.forEach(item => {
//             let divNomeRanking = document.createElement('div');
//             divNomeRanking.classList.add('nome-ranking');
//             divNomeRanking.textContent = `Nome: ${item.nome}, Rank: ${item.rank}`;
//             divDados.appendChild(divNomeRanking);
//         });
//     })
//     .catch(error => console.error('Erro:', error));

    
    // Lista Invertida

    fetch("https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking")
    .then(response => response.json())
    .then(data => {
        let divDados = document.getElementById('dados');
        data.reverse().forEach(item => {
            let divNomeRanking = document.createElement('div');
            divNomeRanking.classList.add('nome-ranking');
            divNomeRanking.textContent = `Nome: ${item.nome}, Rank: ${item.rank}`;
            divDados.appendChild(divNomeRanking);
        });
    })
    .catch(error => console.error('Erro:', error));

