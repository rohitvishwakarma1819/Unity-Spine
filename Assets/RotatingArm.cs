using System.IO.Compression;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingArm : MonoBehaviour
{
    [SerializeField] private GameObject arm;
    // Start is called before the first frame update
    void Start()
    {
        arm.transform.localEulerAngles = new Vector3(0, 0, 78);
        Func();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Func()
    {
        List<A> l = new List<A>();
        l.Add(new A(1));
        l.Add(new A(2));
        l.Add(new A(3));
        l.Add(new A(4));
        l.Add(new A(5));
        l.Add(new A(6));
        A temp = l[0];
        A b = l[0];
        l.RemoveAt(0);
        Destroy(b);
        if (temp == null)
        {
            Debug.Log("null hai rohit");
        }




    }
}
class A : MonoBehaviour
{
    int a;
    public A(int a)
    {
        this.a = a;
    }
}
