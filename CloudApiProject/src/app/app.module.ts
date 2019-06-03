import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { RouterModule} from '@angular/router';

import { ButtonModule } from 'primeng/button';
import { ToolbarModule } from "primeng/toolbar";


import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { SearchComponent } from './search/search.component';
import { RescourseIdComponent } from './rescourse-id/rescourse-id.component'
import { ToolbarComponent } from './toolbar/toolbar.component';
import { PokemonService } from './services/pokemon.service';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    SearchComponent,
    RescourseIdComponent,
    ToolbarComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    ToolbarModule,
    ButtonModule,
    RouterModule.forRoot([
      { path: "home", component: HomeComponent},
      { path: "search", component: SearchComponent},
      { path: "rescourseId", component: RescourseIdComponent},
      { path: "", redirectTo: "home", pathMatch: "full"}
    ])
  ],
  providers: [
    PokemonService,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
