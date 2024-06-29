using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
Clase Pokemon

@author Bruce Munizaga Galleguillos
*/
[CreateAssetMenu(fileName = "Pokemon", menuName = "ScriptableObject/Pokemones")]
public class Pokemon : ScriptableObject
{
    /**
    Id del Pokemon
    */
    [SerializeField]public int id;

    /**
     Nombre del Pokemon
    */
    [SerializeField]public string nombre;

    /**
    Descripcion del Pokemon
    */
    [TextArea]public string descripcion;

    /*
    Funcion que retornara la id del Pokemon
    */
    public int getId(){return this.id;}

    /*
    Funcion que retornara el nombre del Pokemon
    */
    public string getNombre(){return this.nombre;}

    /*
    Funcion que retornara la descripcion del Pokemon
    */
    public string getDescripcion(){return this.descripcion;}

}
