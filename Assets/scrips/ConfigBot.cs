using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigBot : MonoBehaviour
{

    public bool Lento = false;
    public bool Normal = false;
    public bool Rapido = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void VelocidadLenta()
    {
        Time.timeScale = 0.5f;
    }

    public void VelocidadNormal()
    {
        Time.timeScale = 1f;
    }

    public void VelocidadRapida()
    {
        Time.timeScale = 2f;
    }

}
