using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyExplosion: MonoBehaviour
{
    float counter = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter > 0.3f)
        {
            Destroy(gameObject);
        }
    }
}
