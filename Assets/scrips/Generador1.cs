using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador1 : MonoBehaviour
{

    public GameObject Cars_3;

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

    void CreateCars_3()
    {
        Instantiate(Cars_3, transform.position, Quaternion.identity);
    }

    public void IniciarGenerador()
    {
        InvokeRepeating("CreateCars_3",listo, Creando);
    }
}
