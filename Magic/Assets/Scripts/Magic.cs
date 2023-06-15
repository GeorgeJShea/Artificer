using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;


public class Magic : MonoBehaviour
{
    /*
        direction: the way the spell will go
        assumes that is cast from self
        target: 
        shape: the shape of the spell
        example: torrent ball explosion
        target
        element + / -



        secondary effect
        terrary effect
     */

    public GameObject spellObj;
    public Vector3 direction;
    public GameObject origin;
    public string secondary;
    public string smallEffect;
    private MethodInfo method;

    public string element;
    public enum Element { water, fire , air, earth}
    [SerializeField]public Element elli;

    public enum Shape { ball, bolt}
    [SerializeField] public Shape shapi;


    public void Start()
    {
        //string[] temp = new string[] { "fireball", "water", "teal", "forward"};
        //BuildSpell(temp);
    }

    public void CastSpell()
    {
        if(shapi == Shape.ball)
        {
            GameObject spell = Instantiate(spellObj, transform.position, Quaternion.identity);

        }
    }
    public void BuildSpell(string[] methods)
    {
        for (int i = 0; i < methods.Length; i++)
        {
            //Debug.Log(methods[i]);
            string temp = methods[i].ToUpper();
            method = this.GetType().GetMethod(temp);

            Debug.Log(i + "   " + methods[i].ToUpper() + "      " + method);


            //FIREBAll();
            try
            {
                method.Invoke(this, null);
                Debug.Log("Somthing Accured");
            }
            catch
            {
                Debug.Log("Word unused for spell crafting: " + methods[i]);
                // add addintonal information here for players
            }
        }
    }

    public void FORWARD()
    {
        direction = Vector3.forward;
        Debug.Log("Direction Updated");
    }

    public void WATER()
    {
        Debug.Log("test");
    }

    public void FIREBALL()
    {
        FIRE();
        BALL();
    }

    public void FIRE()
    {
        //element = "fire";
        Instantiate(spellObj, transform.position, Quaternion.identity);
        elli = Element.fire;
        //Debug.Log("Fire fire fire");
        // Element script goes here
    }
    public void BALL()
    {
        Debug.Log("ball");
        // shape code here
    }
    
}
