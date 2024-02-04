using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Holay : MonoBehaviour
{
    [SerializeField] GameObject[] cards;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < cards.Length; i++)
        {
            if (GameObject.FindGameObjectsWithTag(i.ToString()).Length < 1)
            {
                Instantiate(cards[i], new Vector3(67f, 13f, 0f), Quaternion.identity);
            }
        }
    }
}
