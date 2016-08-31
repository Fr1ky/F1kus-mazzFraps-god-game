using UnityEngine;
using System.Collections;

public class peonAI : MonoBehaviour
{

    public string peonName = "";
    public int PeonHp;
    public int peonMoveSpeed;
    public bool Male; // pos = male Neg = female;

    [HideInInspector]
    public PeonNames naming;

    //Rigidbody2D body2D;

    // Use this for initialization
    void Start()
    {
        //body2D = GetComponent<Rigidbody2D>();

        if (peonName == "")
        {
            if (Male == true)
            {
                naming.returnName(Male);
                peonName = naming.newName; //call an array full of names and select one randomly   
                gameObject.name = peonName;       
            }
            else
            {
                naming.returnName(Male);
                peonName = naming.newName;
                gameObject.name = peonName;
            }
        }


    }

    // Update is called once per frame
    void Update()
    {

    }



    public void OnTriggerEnter2D(Collider2D vision)
    {

    }

    public void OnTriggerExit2D(Collider2D vision)
    {

    }

    public void idleState()
    {

    }

    public void exploringState()
    {

    }

    public void farmingState()
    {

    }

    public void buildingState()
    {

    }

}
