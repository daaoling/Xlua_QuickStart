using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

    public class baseClass
    {
        public void test() { Debug.Log("baseClass"); }
        
    }
    public class driveClass : baseClass
    {
        public void test() { Debug.Log("driveClass"); }
        
    }

    void Start() {
        driveClass d = new driveClass();
        d.test();
    }
}
