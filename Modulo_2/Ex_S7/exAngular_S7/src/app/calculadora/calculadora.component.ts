import { Component } from '@angular/core';

@Component({
  selector: 'app-calculadora',
  templateUrl: './calculadora.component.html',
  styleUrls: ['./calculadora.component.css']
})
export class CalculadoraComponent {
  numero1: number | null = null;
  numero2: number | null = null;
  resposta: string = '';

  calcular(): void {
    if (this.numero1 !== null && this.numero2 !== null) {
      let soma = this.numero1 + this.numero2;
      let subtracao = this.numero1 - this.numero2;
      let multiplicacao = this.numero1 * this.numero2;
      let divisao = this.numero2 !== 0 ? this.numero1 / this.numero2 : 'Indefinido';

      this.resposta = `Soma: ${soma}, Subtração: ${subtracao}, Multiplicação: ${multiplicacao}, Divisão: ${divisao}`;
    }
  }

  limpar(): void {
    this.numero1 = null;
    this.numero2 = null;
    this.resposta = '';
  }
}
