using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouton : MonoBehaviour
{

    [SerializeField]
    private Transform objetAModifier;
        private float Y = -0.1f;
    private bool collisionActive = false;
    private Vector3 originalPosition;
    [SerializeField]


    private void Start()
    {
        originalPosition = objetAModifier.position;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            collisionActive = true;

            // Modifie la position de l'objet sur l'axe Y
            Vector3 newPosition = objetAModifier.position;
            newPosition.y += Y;
            objetAModifier.position = newPosition;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // Vérifie si la collision avec l'objet "Player" est terminée
        if (other.CompareTag("Player"))
        {
            collisionActive = false;
            // Réinitialise la position de l'objet
            ResetPosition();
        }
    }
    private void ResetPosition()
    {
                objetAModifier.position = originalPosition;
    }


}

