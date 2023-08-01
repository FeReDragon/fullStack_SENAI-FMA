// cardapio.interface.ts
import { Bebida } from './bebida.interface';
import { Comida } from './comida.interface';

export interface Cardapio {
  bebidas: Bebida[];
  comidas: Comida[];
}
