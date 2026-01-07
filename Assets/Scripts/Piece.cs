using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public float vitesseRotation = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Fait tourner la pièce sur elle-même
        transform.Rotate(0, 0, vitesseRotation * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider infoObjet)
    {
        if (infoObjet.CompareTag("Player"))
        {
            GestionJoueur joueur = infoObjet.GetComponent<GestionJoueur>();
            if (joueur != null)
            {
                joueur.AjouterScore(1);
                Destroy(gameObject);
            }
        }
    }
}

