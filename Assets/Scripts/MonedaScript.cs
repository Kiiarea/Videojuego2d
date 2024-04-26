using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaScript : MonoBehaviour
{
    Animator miAnimadorController;

    // Start is called before the first frame update
    void Start()
    {
        miAnimadorController = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){

        if (col.name == "Personaje"){
            GameManager.puntos += 1;
            miAnimadorController.SetBool("monedaDestruir", true);
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxCoin);
            Destroy(this.gameObject, 1f);
        } 
    }
}
