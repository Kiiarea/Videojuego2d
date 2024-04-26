using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaScript : MonoBehaviour
{
    Vector3 posicionInicial;

    GameObject personaje;

    public float velocidadFantasma= 2.0f;

    AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
        //personaje = GameObject.Find("Personaje")
        personaje = GameObject.FindGameObjectWithTag("Player");

        _audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(transform.position, personaje.transform.position);
        float velocidadFinal = velocidadFantasma * Time.deltaTime;

        //Si la distancia del fantasma es mayor que 4, entonces me persigue
        if (distancia <= 4.1f)
        {
            //Acción!!!
            Debug.DrawLine(transform.position, personaje.transform.position, Color.red, 2.5f);
            transform.position = Vector3.MoveTowards(transform.position, personaje.transform.position, velocidadFinal);

            if(_audioSource.isPlaying == false){
                _audioSource.Play();
            }

            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position,posicionInicial, velocidadFinal);
                if((transform.position == posicionInicial)&& _audioSource.isPlaying == true){
                _audioSource.Stop();
                Debug.Log("STOP!!!");

                //Vuelta a casa
                Debug.DrawLine(transform.position, personaje.transform.position, Color.white, 2.5f);
                
            }
            
        }
    }
}
