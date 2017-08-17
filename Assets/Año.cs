using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Año  {

public bool esBisiesto(int año)
    {
        if(año % 400==0)
        {
            return true;
        }
       else if(año % 100 == 0)
        {
            return false;
        }
        else if (año % 4 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
