import { Component, OnInit } from '@angular/core';
import { ApiService } from 'src/app/api.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  filmes: any[] = [];
  loading: boolean = true;
  top3Filmes: any[] = [];
  currentIndex: number = 0;
  texto: string = '';
  mostPopularFilme: any;

  constructor(private apiService: ApiService) {}

  ngOnInit() {
    this.apiService.getFilmes().subscribe(
      (response: any[]) => {
        this.filmes = response;
        this.sortAndSetTop3Filmes();
        this.findMostPopularFilme();
        this.loading = false;
        this.currentIndex = 0; 
      },
      (error: any) => {
        console.error('Erro ao obter os filmes:', error);
        this.loading = false;
      }
    );
  }

  sortAndSetTop3Filmes() {
    this.filmes.sort((a, b) => b.avaliacao - a.avaliacao);
    this.top3Filmes = this.filmes.slice(0, 3);
    this.currentIndex = 0; 
  }

  findMostPopularFilme() {
    let maxAvaliacao = -1;
    for (const filme of this.filmes) {
      if (filme.avaliacao > maxAvaliacao) {
        maxAvaliacao = filme.avaliacao;
        this.mostPopularFilme = filme;
      }
    }
  }

  onNext() {
    if (this.currentIndex < this.top3Filmes.length - 1) {
      this.currentIndex++;
    }
  }

  onPrevious() {
    if (this.currentIndex > 0) {
      this.currentIndex--;
    }
  }

  onButtonClick() {
    console.log('botao foi clicado');
  }
}
