using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoundCountAll : MonoBehaviour
{
    [SerializeField]
    Text outText;
    static private int _count = 0;
    private int count
    {
        set
        {
            if (_count != value)
            {
                outText.text=value.ToString();
                _count = value;
            }
        }
        get
        {
            return _count;
        }
    }
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        count++;
        Vector3 v1 = new Vector3(1, 2, 3);
        Vector3 v2 = new Vector3(2, 0.5f, 1);
        v1.Scale(v2);
        Vector3 v3 = Vector3.Scale(v1, v2);


    }
}
