using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class experiment : MonoBehaviour
{
    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public Animator[] atoms;
    public GameObject[] electronic;
    public GameObject molecule;
    public new string name;
    void Awake()
    {
       

         }

    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (enter)
        {
            Debug.Log("entered");
        }
    }
    public magnet mg;
    private float stayCount = 0.0f;
    private void OnTriggerStay(Collider other)
    {
        if (other.name == name)
        {
            if (stay)
            {
                print(stayCount);
                if (stayCount > 2.15f)
                {
                    Debug.Log("staying");
                    molecule.SetActive(true);
                   for(int i = 0; i < atoms.Length; i++)
                    {
                        Debug.Log("staying");
                        atoms[i].enabled = false;
                        electronic[i].SetActive(false);
                    }
                    mg.enabled = true;
                    stay = false;
                    //  stayCount = stayCount - 0.25f;
                }
                else
                {
                    stayCount = stayCount + Time.deltaTime;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (exit)
        {
            mg.enabled = false;
            stay = true;
            molecule.SetActive(false);
            Debug.Log("exit");
        }
    }
}

