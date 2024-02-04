using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] Transform rockTarget;
    [SerializeField] Transform paperTarget;
    [SerializeField] Transform scissorsTarget;

    [SerializeField] GameObject rock;
    [SerializeField] GameObject paper;
    [SerializeField] GameObject scissors;

    [SerializeField] GameObject gameManager;

    Holay holay;


    // Start is called before the first frame update
    void Start()
    {
        holay = gameManager.GetComponent<Holay>();
    }

    // Update is called once per frame
    void Update()
    {
        //print(holay.move);
        //print(GameObject.FindGameObjectsWithTag("0") != null);

        //if (Holay.move)
        //{
        //    switch (gameObject.tag)
        //    {
        //        case "0":
        //            transform.position = Vector3.Lerp(transform.position, rockTarget.transform.position, Time.deltaTime * 2);
        //            break;
        //        case "1":
        //            transform.position = Vector3.Lerp(transform.position, paperTarget.transform.position, Time.deltaTime * 2);
        //            break;
        //        case "2":
        //            transform.position = Vector3.Lerp(transform.position, scissorsTarget.transform.position, Time.deltaTime * 2);
        //            break;

        //    }
        //    Holay.move = false;
        //}

        if (holay.move)
        {
            if(GameObject.FindGameObjectsWithTag("0") != null)
            {
                rock.transform.position = Vector3.Lerp(rock.transform.position, rockTarget.transform.position, Time.deltaTime * 2);
                print("HI");
            }
        }
    }
}
