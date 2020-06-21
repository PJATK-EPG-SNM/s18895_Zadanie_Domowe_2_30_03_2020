using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCoding : MonoBehaviour
{
    //zad 1
    int a = 3;
    float b = 1.5f;

    //zad 2
    bool tak = true;
    bool nie = false;

    //zad 3
    string pwc = "Programuje w C#";
    string epg = "EPG";

    //zad 6 - equals
    public bool Equals()
    {
        if (pwc != epg)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void zad4()
    {
        //zad 4
        Debug.Log(a + " " + b + " " + tak + " " + nie + " " + pwc + " " + epg);
    }

    public void zad5()
    {
        //zad 5
        if (a==b)
        {
            Debug.Log("Jest rowne!");
        }
        else Debug.Log("Nie jest rowne!");

        if (a != b)
        {
            Debug.Log("Nie jest rowne!");
        }
        else Debug.Log("Jest rowne!");

        if (a >= b)
        {
            Debug.Log(a+" jest wieksze lub rowne "+b+ "!");
        }
        else Debug.Log(a + " nie jest wieksze lub rowne " + b + "!");

        if (a > b)
        {
            Debug.Log(a + " jest wieksze niz " + b + "!");
        }
        else Debug.Log((a + " nie jest wieksze niz " + b + "!");

        if (a <= b)
        {
            Debug.Log(a + " jest mniejsze lub rowne " + b + "!");
        }
        else Debug.Log(a + " nie jest mniejsze lub rowne " + b + "!");

        if (a<b)
        {
            Debug.Log(a + " jest mniejsze niz " + b + "!");
        }
        else Debug.Log(a + " nie jest mniejsze niz " + b + "!");
    }
    public void zad6()
    {
        //zad 6 - if
        if (pwc != epg)
        {
            Debug.Log("Napis '" + pwc + "' jest rozny od '" + epg + "'!");
        }
        Equals();
    }
    public void zad7()
    {
        //zad 7
        if ((a == b) && (a >= b))
        {
            Debug.Log(tak);
        }
        else Debug.Log(nie);

        if ((a == b) && (a <= b))
        {
            Debug.Log(tak);
        }
        else Debug.Log(nie);

        if ((a != b) && (a >= b))
        {
            Debug.Log(tak);
        }
        else Debug.Log(nie);

        if ((a != b) && (a <= b))
        {
            Debug.Log(tak);
        }
        else Debug.Log(nie);

        if ((a == b) || (a >= b))
        {
            Debug.Log(tak);
        }
        else Debug.Log(nie);

        if ((a == b) || (a <= b))
        {
            Debug.Log(tak);
        }
        else Debug.Log(nie);

        if ((a != b) || (a >= b))
        {
            Debug.Log(tak);
        }
        else Debug.Log(nie);

        if ((a != b) || (a <= b))
        {
            Debug.Log(tak);
        }
        else Debug.Log(nie);
    }
}

    void Start()
    {
        zad4();
        zad5();
        zad6();
        zad7();
}
