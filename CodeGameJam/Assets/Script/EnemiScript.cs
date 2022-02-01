using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemiScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    private float test = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Log at start");
        text.text = "Hello World";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Fire a projectile
        }

        float X = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * X * Time.deltaTime;
    }
}
