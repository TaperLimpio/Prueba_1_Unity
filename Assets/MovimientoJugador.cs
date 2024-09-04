using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float fuerzaSalto;

    private Rigidbody rigidbody;
    
    

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var movimientoX = Input.GetAxis("Horizontal");
        var movimientoY = Input.GetAxis("Vertical");

        

        var movimiento = new Vector3(movimientoX,0,movimientoY);
        transform.TransformDirection(movimiento);

        transform.Translate(movimiento * Time.deltaTime * velocidad);
        


        if (Input.GetKeyDown(KeyCode.Space)){
            var impulso = new Vector3(0,fuerzaSalto,0);
            rigidbody.AddForce(impulso, ForceMode.Impulse);
        }
    }
}
