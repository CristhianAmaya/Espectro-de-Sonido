using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSpectrumBehavior : MonoBehaviour
{
    public int Numero_Barras;
    public GameObject Bar;
    public GameObject[] Barras;
    // Start is called before the first frame update
    void Start()
    {
        //Crear las barras de sonido
        float posX = 479;
        for (int i = 0; i < Numero_Barras; i++)
        {
            Instantiate(Bar, new Vector3(posX, 262, -100), Quaternion.identity);
            posX += 0.3f;
        }
        //Guardar los objetos que creamos en el arreglo Bars
        Barras = GameObject.FindGameObjectsWithTag("Bar");
    }

    // Update is called once per frame
    void Update()
    {
        //Mínimo 64 - Máximo 1024
        float[] Espectro = new float[1024];
        //0 - Mono
        //0 - Left Stereo
        //1 - Right Stereo
        AudioListener.GetOutputData(Espectro, 0);

        for (int i = 0; i < Numero_Barras; i++)
        {
            Vector3 Escalamiento = Barras[i].transform.localScale;
            Escalamiento.y = Espectro[i] * 50;
            Barras[i].transform.localScale = Escalamiento;
        }
    }
}
