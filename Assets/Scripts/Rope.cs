using System;
using UnityEngine;

public class Rope : MonoBehaviour 
{
    public Weight weight;
    public HingeJoint2D hook;
    public GameObject linkPrefab;

    public int links = 7;

    private void Start()
    {
        GenerateRope();
    }

    private void GenerateRope()
    {
        Rigidbody2D previousLink = hook.GetComponent<Rigidbody2D>();
        for (int i = 0; i < links; i++)
        {
            GameObject link = Instantiate(linkPrefab, this.transform);

            link.GetComponent<HingeJoint2D>().connectedBody = previousLink;

            if (i < links - 1)
            {
                previousLink = link.GetComponent<Rigidbody2D>();
            }
            else
            {
                weight.ConnectRopeEnd(link.GetComponent<Rigidbody2D>());
            }
        }
    }
}
