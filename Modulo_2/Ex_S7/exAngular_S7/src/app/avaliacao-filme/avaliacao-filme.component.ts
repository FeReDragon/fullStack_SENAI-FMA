import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-avaliacao-filme',
  templateUrl: './avaliacao-filme.component.html',
  styleUrls: ['./avaliacao-filme.component.css']
})
export class AvaliacaoFilmeComponent {
  avaliacaoForm = this.formBuilder.group({
    nome: ['', [Validators.required, Validators.minLength(3)]],
    email: ['', [Validators.required, Validators.email]],
    nomeFilme: ['', [Validators.required, Validators.minLength(3)]],
    avaliacao: ['', [Validators.required, Validators.min(1), Validators.max(10)]]
  });

  showSuccessMessage: boolean = false;

  constructor(private formBuilder: FormBuilder) {}

  onSubmit() {
    if (this.avaliacaoForm.valid) {
      this.showSuccessMessage = true;
      setTimeout(() => {
        window.location.reload();
      }, 3000); // Recarrega a página após 3 segundos
    }
  }

  onCancel() {
    this.avaliacaoForm.reset();
  }
}
