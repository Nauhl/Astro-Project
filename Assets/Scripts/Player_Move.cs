using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{

    public float movimiento = 1.0f;        // I-   Mover el objeto 
    public float rotation_move = 1.0f;     // II-  Mover la camara
    public float JumpForce = 1.0f;         // III- Salto

    private Rigidbody cuerpo;              // III- Salto

    public float x, y;

    //private Animator anim;                 

    // Start is called before the first frame update
    void Start()
    {
        

        Cursor.lockState = CursorLockMode.Locked; // II-  Mover la camara
        Cursor.visible = false;                   // II-  Mover la camara
        
        cuerpo = GetComponent<Rigidbody>(); // III- SALTO
    }

    // Update is called once per frame
    void Update()
    {
        //float movimientoX = Input.GetAxis("Horizontal") * Time.deltaTime * movimiento;

        //float movimientoZ = Input.GetAxis("Vertical") * Time.deltaTime * movimiento;

        // MOVIMIENTO
        float Horizontal = Input.GetAxis("Horizontal");           // I-Mover el objeto
        float Vertical = Input.GetAxis("Vertical");               // I-Mover el objeto

        transform.Translate(new Vector3(Horizontal, 0.0f, Vertical) * Time.deltaTime * movimiento);         // I-Mover el objeto

        // ROTACION
        float rotationY = Input.GetAxis("Mouse X");        // II-  Mover la camara

        transform.Rotate(new Vector3(0, rotationY * Time.deltaTime * rotation_move, 0));   // II-  Mover la camara      

        

        // SALTO
        if (Input.GetKeyDown(KeyCode.Space)) {
            cuerpo.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);  // III- Salto
        } 

    }
}
