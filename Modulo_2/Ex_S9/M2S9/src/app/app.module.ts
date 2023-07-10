import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BuscaComponent } from './busca/busca.component';
import { HomeComponent } from './home/home.component';
import { HeaderComponent } from './header/header.component';
import { FormsModule } from '@angular/forms'; // Importe o módulo FormsModule
import { FullComponent } from './layouts/full/full.component';
import { LoginComponent } from './login/login.component';
import { PublicoRoutingModule } from './components/publico/publico-routing.module';
import { PrivadoRoutingModule } from './components/privado/privado-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    BuscaComponent,
    HomeComponent,
    HeaderComponent,
    FullComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    PublicoRoutingModule,
    PrivadoRoutingModule, // Adicione FormsModule aqui
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

