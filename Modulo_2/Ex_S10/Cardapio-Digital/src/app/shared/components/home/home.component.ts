import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router'; // importa o serviço Router

interface Opcao { // Aqui, declaramos uma interface para definir o tipo de opção
  titulo: string;
  imagem: string;
  rota: string; // adicione um campo rota para especificar a rota correspondente para cada opção
}

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})

export class HomeComponent implements OnInit {
  opcoes: Opcao[] = [ // Aqui, tipificamos opcoes como um array de Opcao
    {
      titulo: 'Comidas',
      imagem: 'URL_DA_IMAGEM_COMIDA',
      rota: '/comidas' // aqui, especificamos a rota correspondente para comidas
    },
    {
      titulo: 'Bebidas',
      imagem: 'URL_DA_IMAGEM_BEBIDA',
      rota: '/bebidas' // aqui, especificamos a rota correspondente para bebidas
    }
  ];

  constructor(private router: Router) { } // injeta o serviço Router

  ngOnInit(): void {
  }

  cliqueOpcao(opcao: Opcao) { // Aqui, tipificamos opcao como Opcao
    this.router.navigate([opcao.rota]); // navega para a rota especificada para a opção clicada
  }
}

