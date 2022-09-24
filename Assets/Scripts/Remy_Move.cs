using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remy_Move : MonoBehaviour
{


    // OnCollisionEnter - INICIO DE LA COLISION
    // OnCollisionStay  - Seguimiento a la colision
    // OnCollisionExit  - Fin de la colision



    public float velocidadMovimiento = 5.0f; // I-   Mover el objeto
    public float velocidadRotacion = 200.0f;
    public float JumpForce = 1.0f;         // III- Salto

    private Rigidbody cuerpo;

    public float x, y;

    private Animator anim; // IV.- Cambio de color al chocar con columnas que giran 

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
        cuerpo = GetComponent<Rigidbody>(); //III SALTO 
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);


        // SALTO
        if (Input.GetKeyDown(KeyCode.Space)) {
            cuerpo.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);  // III- Salto
        } 

        
    }

    
}
