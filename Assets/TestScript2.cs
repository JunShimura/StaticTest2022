using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        //var t = GetComponent<TextMeshPro>();
       
        Debug.Log(TestStaticClass.testInt++);
        Debug.Log(TestScene1.testString.ToString());
    }
}
