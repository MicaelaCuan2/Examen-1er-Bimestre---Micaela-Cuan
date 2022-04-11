using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*De qué orientación sos?
Todos los ingresos se hacen por Inspector. 
Ingresar:
nombre de alumno
de qué año es (un número del 1 al 5)
a qué orientación pertenece (sólo se puede ingresar la inicial en mayúscula de la especialidad: T para TIC, D para Diseño, G para Gestión,
M para Medios y H para Humanidades).

El programa debe cumplir los siguientes requerimientos:

Mostrar un mensaje de error si el nombre ingresado es una cadena de caracteres vacía y si el año ingresado no está en el rango del 1 al 5. 

Si se ingresa un valor diferente a las opciones válidas en el campo ingreso de orientación escribir en consola “Solo puede ingresar T, D, G, M o H”. 

Si el año ingresado no está entre 3 y 5 se debe mostrar el mensaje “Error. Aún estás en el ciclo básico”.

Si los ingresos de nombre, año y orientación son válidos escribir en consola un mensaje de agradecimiento en el siguiente formato:
“Muchas gracias [nombreAlumno]!”
*/
public class Ejercicio : MonoBehaviour
{
    public string nombreAlumno;
    public int anio;
    public string orientacion;
    // Start is called before the first frame update
    void Start()
    {

        if (nombreAlumno.Length == 0 || anio < 1 || anio > 5)
        {
            Debug.Log("Error");
        }
        else if (anio < 3)
        {
            Debug.Log("Error. Aún estás en ciclo básico");
        }
        else if (orientacion != "T" && orientacion != "M" && orientacion != "G" && orientacion != "H" && orientacion != "D" )
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
        }
        else
        {
            Debug.Log("Muchas gracias " + nombreAlumno + "!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
