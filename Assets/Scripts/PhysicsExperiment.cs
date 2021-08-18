using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Test
{
    float a = 10;
    int b = 12;
    string s = "rohit";
}
public class PhysicsExperiment : MonoBehaviour
{
    public GameObject obj;
    public float angle, angleMin;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody rb = obj.GetComponent<Rigidbody>();
        Test a = new Test();
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         GameObject t = Instantiate(obj, Vector3.zero, Quaternion.identity);
    //         Rigidbody rb = t.GetComponent<Rigidbody>();
    //         // rb.velocity = RandomVector2(angle, angleMin);
    //         Vector2 direction = RandomVector2(angle, angleMin);
    //         rb.AddForce(direction * speed, ForceMode.Impulse);
    //         Debug.DrawRay(transform.position, direction, Color.green, 2f);
    //         Destroy(t, 1);

    //     }
    //     Debug.DrawRay(Vector2.zero, new Vector2(Mathf.Cos(angleMin), Math.Sign(angleMin)), Color.green);
    //     Debug.DrawRay(Vector2.one, RandomVector2(angle, angleMin), Color.white);

    // }
    // public Vector2 RandomVector2(float angle, float angleMin)
    // {
    //     angle = Mathf.PI * angle / 180.0f;
    //     angleMin = Mathf.PI * angleMin / 180.0f;
    //     float random = UnityEngine.Random.value * angle + angleMin;
    //     return new Vector2(Mathf.Cos(random), Mathf.Sin(random));
    // }
}
