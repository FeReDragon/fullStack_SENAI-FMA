import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from '../app/shared/components/home/home.component';
import { ComidasComponent } from '../app/pages/comidas/comidas.component';
import { BebidasComponent } from '../app/pages/bebidas/bebidas.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'comidas', component: ComidasComponent },
  { path: 'bebidas', component: BebidasComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
