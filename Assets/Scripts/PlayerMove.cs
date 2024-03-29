using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
        private int speed = 10;
    [SerializeField]
    private Rigidbody rigidbody;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");
        if (MoveHorizontal != 0 || MoveVertical != 0)
        {
            Vector3 Movement = new Vector3(MoveHorizontal, 0, MoveVertical);
            rigidbody.AddForce(Movement * speed * Time.deltaTime);
        }
        if (Mathf.Abs(MoveHorizontal) > 0 || Mathf.Abs(MoveVertical) > 0)
        {
            Vector3 Movement = new Vector3(MoveHorizontal, 0, MoveVertical);
            rigidbody.AddForce(Movement * speed * Time.deltaTime);
        }
        else
        {
            // Si aucune touche n'est enfoncée, la vitesse retourne à 0
            rigidbody.velocity = Vector3.zero;
        }
    }
}