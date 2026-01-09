using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public float vitesseRotation = 100f;

    void Update()
    {
        transform.Rotate(0, 0, vitesseRotation * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider infoObjet)
    {
        if (infoObjet.CompareTag("Player"))
        {
            GestionJoueur joueur = infoObjet.GetComponent<GestionJoueur>();

            Destroy(gameObject);
        }
    }
}
