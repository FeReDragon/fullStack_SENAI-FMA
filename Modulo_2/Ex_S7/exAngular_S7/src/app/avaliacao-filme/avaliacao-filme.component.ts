import { Component } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

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

  onSubmit() {
    if (this.avaliacaoForm.valid) {
      console.log(`Você avaliou o filme ${this.avaliacaoForm.value.nomeFilme}`);
      this.avaliacaoForm.reset();
    } else {
      console.log('Formulário inválido');
    }
  }

  onCancel() {
    this.avaliacaoForm.reset();
  }


}
