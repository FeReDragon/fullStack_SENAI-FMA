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
  currentIndex: number = 0;
  totalFilmes: number = 0;
  texto= '';

  constructor(private apiService: ApiService) {}

  ngOnInit() {
    this.apiService.getFilmes().subscribe(
      (response: any[]) => {
        this.filmes = response;
        this.totalFilmes = this.filmes.length;
        this.loading = false;
      },
      (error: any) => {
        console.error('Erro ao obter os filmes:', error);
        this.loading = false;
      }
    );
  }

  onNext() {
    if (this.currentIndex < this.totalFilmes - 1) {
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

