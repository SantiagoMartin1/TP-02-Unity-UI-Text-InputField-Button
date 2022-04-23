using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayoriaDeEdad : MonoBehaviour
{

    public int edadUsu;

    // Start is called before the first frame update
    void Start()
    {
        
        if (edadUsu >= 18)
        {
            Debug.Log("Mayor de edad");
        }
        else
        {
            Debug.Log("No es mayor de edad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
