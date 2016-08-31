using UnityEngine;
using System.Collections;

public class materialsStored : MonoBehaviour
{
    public int currentWood;
    public int currentStone;
    public int currentFood;

    public int MaxResources;

    public int buildingLevel;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int all = currentWood + currentStone + currentFood;
        if (all >= MaxResources)
        {

        }


    }

    // OnTriggerExit is called when the Collider other has stopped touching the trigger
    public void OnTriggerExit(Collider other)
    {
        //enable resource deposit
    }

    // OnTriggerEnter2D is called when the Collider2D other enters the trigger (2D physics only)
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //disable resource depost
    }
}
