using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] Transform rockTarget;
    [SerializeField] Transform paperTarget;
    [SerializeField] Transform scissorsTarget;
    [SerializeField] Transform point;
    bool allowedToMove = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != point.transform.position)
        {
            allowedToMove = true;
        }
        else
        {
            allowedToMove = false;
        }

        if (allowedToMove)
        {
            switch (gameObject.tag)
            {
                case "0":
                    transform.position = Vector3.Lerp(transform.position, point.transform.position, Time.deltaTime * 2);
                    break;
                case "1":
                    transform.position = Vector3.Lerp(transform.position, point.transform.position, Time.deltaTime * 2);
                    break;
                case "2":
                    transform.position = Vector3.Lerp(transform.position, point.transform.position, Time.deltaTime * 2);
                    break;

            }
        }
    }
}
