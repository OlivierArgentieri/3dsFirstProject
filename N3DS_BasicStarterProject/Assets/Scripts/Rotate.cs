using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.N3DS;
using Debug = UnityEngine.N3DS.Debug;

public class Rotate : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        if(GamePad.GetButtonHold(N3dsButton.B))
            this.transform.Rotate(Vector3.up);

        if (GamePad.GetButtonHold(N3dsButton.A))
            this.transform.Rotate(Vector3.forward);
    }
}
