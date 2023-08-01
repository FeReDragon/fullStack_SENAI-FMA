import { Component, OnInit } from '@angular/core';
import { CardapioService } from '../../cardapio.service';
import { Comida } from '../../shared/Interfaces/comida.interface';

@Component({
  selector: 'app-comidas',
  templateUrl: './comidas.component.html',
  styleUrls: ['./comidas.component.scss']
})
export class ComidasComponent implements OnInit {
  comidas: Comida[] = [];

  constructor(private cardapioService: CardapioService) { }

  ngOnInit(): void {
    this.cardapioService.getComidas().subscribe(data => {
      this.comidas = data;
    });
  }
}


