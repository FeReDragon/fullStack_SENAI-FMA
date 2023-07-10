import { Component, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-busca',
  templateUrl: './busca.component.html',
  styleUrls: ['./busca.component.scss']
})
export class BuscaComponent {
  @Output() searchText = new EventEmitter<string>();

  handleInput() {
    this.searchText.emit('Valor do input');
  }
}







