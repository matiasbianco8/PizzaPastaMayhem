using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchPrueba : MonoBehaviour
{

    int launchCount;

    void Awake()
    {
        // chequea el player pref
        launchCount = PlayerPrefs.GetInt("testjuegoabierto", 0);

        // luego del chequeo de arriba, le suma 1
        launchCount = launchCount + 1;

        // actualiza el player pref
        PlayerPrefs.SetInt("testjuegoabierto", launchCount);


        print(launchCount);

        // destruye el script y solo corre una sola vez por sesion
        Destroy(this);


    }

        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
