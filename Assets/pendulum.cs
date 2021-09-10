using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pendulum : MonoBehaviour
{
    // Start is called before the first frame update
    float timer = 0f;
    float speed = 1f;
    int phase = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.fixedDeltaTime;
        if (timer > 1f)
        {
            phase++;
            phase %= 4;
            timer = 0f;
        }

        switch (phase)
        {
            case 0:
                transform.Rotate(0, 0, speed * (1-timer));
                break;
            case 1:
                transform.Rotate(0, 0, -speed * timer);
                break;
            case 2:
                transform.Rotate(0, 0, -speed * (1-timer));
                break;
            case 3:
                transform.Rotate(0, 0, speed * timer);
                break;
        }
    }
}
