using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

/*
*Clase que decidira que pokemon mostrar en la Pokedex
*@author Bruce Munizaga Galleguillos
*/
public class PokemonManager : MonoBehaviour
{

    //Contenedor de pokemones
    [SerializeField] GameObject[] pokemones = new GameObject[7];

    /*
    *Metodo que controlara que pokemon mostrara al seleccionar un modelo 3D
    */
    public void ObtenerId(int id){
        InfoPokemones(id);     
    }


    /*
    *Metodo que activara el gameObject del pokemon seleccionado
    *@param id del pokemon seleccionado
    */
    public void InfoPokemones(int id){

        switch(id){
            case 1: 
            this.pokemones[0].gameObject.SetActive(true);
            this.pokemones[5].gameObject.SetActive(true);
            this.pokemones[6].gameObject.SetActive(false);
            break;
            
            case 2: 
            this.pokemones[1].gameObject.SetActive(true);
            this.pokemones[5].gameObject.SetActive(true);
            this.pokemones[6].gameObject.SetActive(false);
            break;
            
            case 3: 
            this.pokemones[2].gameObject.SetActive(true);
            this.pokemones[5].gameObject.SetActive(true);
            this.pokemones[6].gameObject.SetActive(false);
            break;

            case 4: 
            this.pokemones[3].gameObject.SetActive(true);
            this.pokemones[5].gameObject.SetActive(true);
            this.pokemones[6].gameObject.SetActive(false);
            break;
            
            case 5: 
            this.pokemones[4].gameObject.SetActive(true);
            this.pokemones[5].gameObject.SetActive(true);
            this.pokemones[6].gameObject.SetActive(false);
            break;
        }
    }

    /*
    *Metod que desactivara el gameObject activado del arreglo de pokemones
    */
    public void QuitarInfo(){

        for(int i = 0; i < 5; i++){

            if(this.pokemones[i] == true){
                this.pokemones[i].gameObject.SetActive(false);
                this.pokemones[5].gameObject.SetActive(false);
                this.pokemones[6].gameObject.SetActive(true);
            }
        }
    }
}
