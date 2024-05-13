using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Test()
    {
        this.gameObject.SetActive(!this.gameObject.activeSelf);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
