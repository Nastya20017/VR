using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLogic : MonoBehaviour
{
    int yy = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Test()
    {
        this.gameObject.SetActive(!this.gameObject.activeSelf);
    }

    public void Test2()
    {
        var ttt = this.gameObject.GetComponent<Text>();
        ttt.text = (yy++).ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
