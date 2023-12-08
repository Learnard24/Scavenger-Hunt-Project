using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject objnametext;
    private void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(objnametext);
        ScoreManager.instance.AddPoint();
    }
}
