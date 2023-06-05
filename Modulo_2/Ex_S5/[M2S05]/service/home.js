let mockData = [
    {
        titulo: 'iTech',
        imagem: 'img/001.jpg',
        subtitulo: 'Este livro é para amantes de tecnologia.'
    },
    {
        titulo: 'Sucess',
        imagem: 'img/002.jpg',
        subtitulo: 'livro para o sucesso!!!'
    },
    {
        titulo: 'Secrets mock',
        imagem: 'img/003.jpg',
        subtitulo: 'Segredos do sucesso'
    },
    {
        titulo: 'Html 5',
        imagem: 'img/004.jpg',
        subtitulo: 'linguagem html'
    },
    {
        titulo: 'Design digital',
        imagem: 'img/005.png',
        subtitulo: 'Design digitl do futuro'
    },
    {
        titulo: 'Mock-up',
        imagem: 'img/0006.jpg',
        subtitulo: 'Segredos do mock-up'
    },
    {
        titulo: 'Scool',
        imagem: 'img/007.jpg',
        subtitulo: 'escola do futuro'
    },
    {
        titulo: 'Segrdos do Sucesso',
        imagem: 'img/0008.jpg',
        subtitulo: 'livro segrdos do sucesso'
    },
    {
        titulo: 'Black Book',
        imagem: 'img/09.jpg',
        subtitulo: 'Tudo por tras do livro mais procurado'
    }
];

document.addEventListener('DOMContentLoaded', function() {
    let cardContainer = document.getElementById('card-container');
    displayItems(cardContainer, mockData);
  
    let searchButton = document.getElementById('search-button');
    searchButton.addEventListener('click', function() {
      let searchInput = document.getElementById('search-input');
      let searchTerm = searchInput.value.toLowerCase();
      let filteredData = mockData.filter(item => 
        item.titulo.toLowerCase().includes(searchTerm) || 
        item.subtitulo.toLowerCase().includes(searchTerm) // adicionado aqui
      );
      displayItems(cardContainer, filteredData);
    });
});

function displayItems(container, items) {
    // Primeiro, limpa todos os cards existentes
    container.innerHTML = '';

    // Em seguida, cria e exibe os novos cards
    items.forEach(item => {
      let card = document.createElement('div');
      card.className = 'card';

      let title = document.createElement('h2');
      title.textContent = item.titulo;
      card.appendChild(title);

      let image = document.createElement('img');
      image.src = item.imagem;
      card.appendChild(image);

      let subtitle = document.createElement('p');
      subtitle.textContent = item.subtitulo;
      card.appendChild(subtitle);

      container.appendChild(card);
    });
}