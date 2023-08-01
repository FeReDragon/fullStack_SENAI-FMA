import { Component, OnInit } from '@angular/core';
import { CardapioService } from '../../cardapio.service';
import { Bebida } from '../../shared/Interfaces/bebida.interface'; // Atualize este caminho para o caminho correto do arquivo de interface.

@Component({
  selector: 'app-bebidas',
  templateUrl: './bebidas.component.html',
  styleUrls: ['./bebidas.component.scss']
})

export class BebidasComponent implements OnInit {
  bebidas: Bebida[] = []; // Aqui, a variável bebidas foi declarada como um array de Bebida

  constructor(private cardapioService: CardapioService) { }

  ngOnInit(): void {
    this.cardapioService.getBebidas().subscribe(data => {
      this.bebidas = data;
    });
  }
}

