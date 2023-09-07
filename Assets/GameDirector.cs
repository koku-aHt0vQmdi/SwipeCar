using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;//TextMeshPro‚ðŽg‚¤‚½‚ß‚É•K—v!

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    int count = 0;
    int time = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;

        if (length >= 0)
            time = 1;
        else if (time >= 1 && length <= 1)
        {
            count++;
            time = 0;
        }

        if (length < 0)
            this.distance.GetComponent<TextMeshProUGUI>().text = "Distance" + (-(length)).ToString("F2") + "m\r\nflag:" + count;
        else
            this.distance.GetComponent<TextMeshProUGUI>().text = "Distance:" + length.ToString("F2") + "m\r\nflag:" + count;
    }
}
