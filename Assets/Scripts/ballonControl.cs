using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ballonControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explosionPrefab;
    gameControl gameControlScript;

    void Start()
    {
        gameControlScript = GameObject.Find("control").GetComponent<gameControl>();

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1));
        if (transform.position.y > 6)
            Destroy(gameObject);
        

    }
    public void OnMouseDown()
    {
        Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
        gameControlScript.Score();
        Destroy(gameObject);
        
    }
}
