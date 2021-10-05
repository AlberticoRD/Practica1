using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador4 : MonoBehaviour
{
    public GameObject CamionAzul;

    [Range(0f, 10f)]
    public float Creando = 5f;
    [Range(0f, 10f)]
    public float listo = 4f;

    void Start()
    {
        IniciarGenerador();
    }

    void Update()
    {

    }

    void CreateCamionAzul()
    {
        Instantiate(CamionAzul, transform.position, Quaternion.identity);
    }

    public void IniciarGenerador()
    {
        InvokeRepeating("CreateCamionAzul", listo, Creando);
    }


}
