using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float horiInput;
    public float vertInput;
    public float horiSpeed = 5;
    public float vertSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horiInput = Input.GetAxis("Horizontal");
        vertInput = Input.GetAxis("Vertical");
        transform.Translate(horiSpeed * Time.deltaTime * Vector2.right * horiInput);
        transform.Translate(vertSpeed * Time.deltaTime * Vector2.up * vertInput);
    }
}
