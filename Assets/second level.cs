using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneMananger;


public class secondlevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Inmput.GetKeyDown(keyCode.Space) == true)
        {
            SceneManager.LoadScene("Segundo nivel");
        }
    }
}
