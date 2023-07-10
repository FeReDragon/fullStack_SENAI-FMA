import { Component } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-avaliacao-filme',
  templateUrl: './avaliacao-filme.component.html',
  styleUrls: ['./avaliacao-filme.component.css']
})
export class AvaliacaoFilmeComponent {
  avaliacaoForm = new FormGroup({
    nome: new FormControl('', [Validators.required, Validators.minLength(3)]),
    email: new FormControl('', [Validators.required, Validators.email]),
    nomeFilme: new FormControl('', [Validators.required, Validators.minLength(3)]),
    avaliacao: new FormControl('', [Validators.required, Validators.min(1), Validators.max(10)])
  });

  avaliacoesProntas: any[] = []; // Inicialize a propriedade com um array vazio

  constructor(private apiService: ApiService) {
  }

  ngOnInit() {
    this.apiService.get('avaliacoes-prontas').subscribe(
      (response: any) => {
        this.avaliacoesProntas = response;
      },
      (error: any) => {
        console.error('Erro ao obter as avaliações prontas:', error);
      }
    );
  }

  onSubmit() {
    if (this.avaliacaoForm.valid) {
      const { nome, email, nomeFilme, avaliacao } = this.avaliacaoForm.value;

      console.log(`Nome: ${nome}`);
      console.log(`Email: ${email}`);
      console.log(`Nome do Filme: ${nomeFilme}`);
      console.log(`Avaliação: ${avaliacao}`);

      console.log(`Você avaliou o filme ${nomeFilme}`);
      this.avaliacaoForm.reset();
    } else {
      console.log('Formulário inválido');
    }
  }

  onCancel() {
    this.avaliacaoForm.reset();
  }
}
