using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;

public class SpeechToText : MonoBehaviour
{
    // Speech Regnozier

    public GameObject cube;
    public GameObject magicSystem;

    private DictationRecognizer dictRecognize;

    public string spell = "";
    private List<string> magicWords;
    private List<string> magicReset;
    Magic magic;

    void Start()
    {
        magic = magicSystem.GetComponent<Magic>();
        magicWords = new List<string>();
        magicReset = magicWords;
        dictRecognize = new DictationRecognizer();
        dictRecognize.DictationHypothesis += Result;
    }
    void Update()
    {
        InputGather();

        /*
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("dead");
            dictRecognize.Dispose();
        }
        */
    }
    private void InputGather()
    {
        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Spell start");
        }
        if (Input.GetKey("a"))
        {
            dictRecognize.Start();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {

            dictRecognize.Stop();

            Debug.Log("Spell Completed: " + spell + "|");
            magicWords.Clear();
        }

        */
    }
    private void Result(string text)
    {
        if(text != null)
        {
            Debug.Log(" " + text + "   ");
            //Debug.Log("Word appended");
            magicWords.Add(text);
            if (magicWords.Count != 0)
            {
                spell = magicWords[magicWords.Count - 1];
                Debug.Log(spell);

                magic.BuildSpell(magicWords.ToArray());
            }
            else
            {
                Debug.Log("REE");
            }
        }
    }

    private void processText(string text)
    {

    }

}

