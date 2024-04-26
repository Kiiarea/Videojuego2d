using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private GameObject personaje;
    private MovPersonaje movPersonaje;

    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.Find("Personaje");
        movPersonaje = personaje.GetComponent<MovPersonaje>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){

        if (col.name == "Personaje")
        {
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxDead);
            movPersonaje.Respawnear();
        }
    }

}
