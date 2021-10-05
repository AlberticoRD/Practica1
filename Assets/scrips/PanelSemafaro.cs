using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSemafaro : MonoBehaviour
{
    public List<GameObject> semafobajoiz;
    public List<GameObject> semaabajode;
    public List<GameObject> semaforoarride;
    public List<GameObject> semaforoarriiz;
    public List<GameObject> parar;
    public List<GameObject> seguir;
    public List<GameObject> destructor;




    void Start()
    {
        StartCoroutine(PanelDeSemaforo(5f));
    }

    void Update()
    {

    }

    void SemaforoArribaAbajoRojo()
    {
        semaabajode[0].SetActive(true);
        semaabajode[1].SetActive(false);
        semaabajode[2].SetActive(false);

        semaforoarriiz[0].SetActive(true);
        semaforoarriiz[1].SetActive(false);
        semaforoarriiz[2].SetActive(false);

        parar[3].SetActive(true);
        parar[2].SetActive(true);

        seguir[3].SetActive(false);
        seguir[2].SetActive(false);

        destructor[0].SetActive(true);
        destructor[2].SetActive(true);



    }

    void SemaforoArribaAbajoAmarrillo()
    {
        semaabajode[0].SetActive(false);
        semaabajode[1].SetActive(true);
        semaabajode[2].SetActive(false);

        semaforoarriiz[0].SetActive(false);
        semaforoarriiz[1].SetActive(true);
        semaforoarriiz[2].SetActive(false);

        parar[3].SetActive(true);
        parar[2].SetActive(true);

        seguir[3].SetActive(false);
        seguir[2].SetActive(false);

        destructor[0].SetActive(false);
        destructor[2].SetActive(false);


    }

    void SemaforoArribaAbajoVerde()
    {
        semaabajode[0].SetActive(false);
        semaabajode[1].SetActive(false);
        semaabajode[2].SetActive(true);

        semaforoarriiz[0].SetActive(false);
        semaforoarriiz[1].SetActive(false);
        semaforoarriiz[2].SetActive(true);

        parar[3].SetActive(false);
        parar[2].SetActive(false);

        seguir[3].SetActive(true);
        seguir[2].SetActive(true);

        destructor[0].SetActive(false);
        destructor[2].SetActive(false);

    }

    void SemaforoDerechaIzquierdaRojo()
    {
        semafobajoiz[0].SetActive(true);
        semafobajoiz[1].SetActive(false);
        semafobajoiz[2].SetActive(false);

        semaforoarride[0].SetActive(true);
        semaforoarride[1].SetActive(false);
        semaforoarride[2].SetActive(false);

        parar[0].SetActive(true);
        parar[1].SetActive(true);

        seguir[0].SetActive(false);
        seguir[1].SetActive(false);

        destructor[3].SetActive(true);
        destructor[1].SetActive(true);

    }

    void SemaforoDerechaIzquierdaAmarrillo()
    {
        semafobajoiz[0].SetActive(false);
        semafobajoiz[1].SetActive(true);
        semafobajoiz[2].SetActive(false);

        semaforoarride[0].SetActive(false);
        semaforoarride[1].SetActive(true);
        semaforoarride[2].SetActive(false);

        parar[0].SetActive(false);
        parar[1].SetActive(false);

        seguir[0].SetActive(true);
        seguir[1].SetActive(true);

        destructor[3].SetActive(false);
        destructor[1].SetActive(false);
    }

    void SemaforoDerechaIzquierdaVerde()
    {
        semafobajoiz[0].SetActive(false);
        semafobajoiz[1].SetActive(false);
        semafobajoiz[2].SetActive(true);

        semaforoarride[0].SetActive(false);
        semaforoarride[1].SetActive(false);
        semaforoarride[2].SetActive(true);

        parar[0].SetActive(false);
        parar[1].SetActive(false);

        seguir[0].SetActive(true);
        seguir[1].SetActive(true);

        destructor[3].SetActive(false);
        destructor[1].SetActive(false);

    }

    IEnumerator PanelDeSemaforo(float tiempo)
    {
        while (true)
        {
            SemaforoArribaAbajoRojo();
            SemaforoDerechaIzquierdaVerde();
            yield return new WaitForSeconds(tiempo);
            SemaforoDerechaIzquierdaAmarrillo();
            yield return new WaitForSeconds(tiempo);
            SemaforoDerechaIzquierdaRojo();
            SemaforoArribaAbajoVerde();
            yield return new WaitForSeconds(tiempo);
            SemaforoArribaAbajoAmarrillo();
            yield return new WaitForSeconds(tiempo);
           
        }

    }

}      




