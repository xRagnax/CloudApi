import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class PokemonService {

  constructor(private http: HttpClient) { }

  getPokemon()
  {
    return this.http.get<Result>("https://pokeapi.co/api/v2/pokemon")
  }
}
export interface Result {
  name: string;
  url: string;
}

export interface IPokemon {
  count: number;
  next: string;
  previous?: any;
  results: Result[];
}