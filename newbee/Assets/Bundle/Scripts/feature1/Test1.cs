using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    public ModelTest model;
    void Start()
    {
        model = new ModelTest();
        model.age = 10;
        Debug.Log(model.age);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
