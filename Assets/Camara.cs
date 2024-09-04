using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    private Camera camara;
    // Start is called before the first frame update
    void Start()
    {

        camara = GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        var ejeX = Input.GetAxis("Mouse X");
        var rotacion = new Vector3(0,ejeX,0);
        camara.transform.Rotate(rotacion);
    }
}
