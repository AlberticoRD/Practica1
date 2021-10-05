using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador2 : MonoBehaviour
{
    public GameObject Cars_2;

    [Range(0f, 10f)]
    public float Creando = 3f;
    [Range(0f, 10f)]
    public float listo = 1f;

    
    void Start()
    {
        IniciarGenerador();
    }

    void Update()
    {

    }

    void CreateCars_2()
    {
        Instantiate(Cars_2, transform.position, Quaternion.identity);
    }

    public void IniciarGenerador()
    {
        InvokeRepeating("CreateCars_2", listo, Creando);
    }


}
