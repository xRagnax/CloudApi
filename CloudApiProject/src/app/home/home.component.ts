import { Component, OnInit } from '@angular/core';
import { PokemonService, Result } from '../services/pokemon.service';
import * as _ from "lodash"
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

 result : string;

  constructor(private pokemonSvc: PokemonService) 
  {

  }

  ngOnInit() {
    
    this.pokemonSvc.getPokemon().subscribe(pokemons => {
      
      this.result = pokemons.name
      
    })
  }

}
