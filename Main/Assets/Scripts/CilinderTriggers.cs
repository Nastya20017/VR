using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CilinderTriggers : MonoBehaviour
{
    public Text Text;
    int yy = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        yy++;
        Text.text = yy.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
