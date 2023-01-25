using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingTheGrid : MonoBehaviour
{
    public SpriteRenderer _square; 

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            SpriteRenderer temp = Instantiate(_square, this.transform);
            temp.transform.position = new Vector3(i * 2.0f, i * 2.0f); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
