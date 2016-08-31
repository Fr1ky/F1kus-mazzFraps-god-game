using UnityEngine;
using System.Collections;

public class PeonNames : MonoBehaviour {

    public string[] maleNames;
    public string[] femaleNames;
    [HideInInspector]
   public string newName;

    public void returnName(bool array)
    {
        if (array)
        {
           int i = maleNames.Length;
            int pos = Random.Range(0, i);
            //  newName.Equals(maleNames.GetValue(pos));
            newName = maleNames[pos];
        }
        else
        {
            int i = femaleNames.Length;
            int pos = Random.Range(0, i);
            //  newName.Equals(maleNames.GetValue(pos));
            newName = femaleNames[pos];
        }
    }
}
