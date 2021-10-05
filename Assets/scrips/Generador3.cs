using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador3 : MonoBehaviour
{
    public GameObject CamionRojo;

    [Range(0f, 10f)]
    public float Creando = 3f;
    [Range(0f, 10f)]
    public float listo = 2f;

    void Start()
    {
        IniciarGenerador();
    }

    void Update()
    {

    }

    void CreateCamionRojo()
    {
        Instantiate(CamionRojo, transform.position, Quaternion.identity);
    }

    public void IniciarGenerador()
    {
        InvokeRepeating("CreateCamionRojo", listo, Creando);
    }

}
