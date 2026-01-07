using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffreInteractif : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider infoObjet)
    {
        if (infoObjet.CompareTag("Player"))
        {
            GestionJoueur joueur = infoObjet.GetComponent<GestionJoueur>();

            if (joueur != null && joueur.aLaCle == true)
            {
                GetComponent<Animator>().SetTrigger("Ouvrir");
                Debug.Log("Coffre Ouvert !");
            }
            else
            {
                Debug.Log("Il te faut la clé !");
            }
        }
    }
}
