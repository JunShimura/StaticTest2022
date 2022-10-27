using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TestScene1 : MonoBehaviour
{
    static public string testString = "TEST static STRING ";
    // Start is called before the first frame update
    void Start()
    {
        var vector3 = new Vector3(1, 2, 3);
        var length= vector3.magnitude;
        Debug.Log($"length={length}");
        length = Vector3.Magnitude(new Vector3(1, 2, 3));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(1);
        }
    }
}
