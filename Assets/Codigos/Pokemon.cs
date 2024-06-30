using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
*Clase Pokemon
*@author Bruce Munizaga Galleguillos
*/
public class Pokemon : MonoBehaviour
{
    /**
    Id del Pokemon
    */
    [SerializeField]public int id;

    [SerializeField]public PokemonManager pokemonManager;

    /*
    Funcion que retornara la id del Pokemon hacia el PokemonManager
    */
    private void OnMouseDown(){this.pokemonManager.ObtenerId(this.id);}
}
