using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Test : MonoBehaviour
{
    //String[] stringarr = new String[] { "Geeks", "GFG", "Noida" };

    public bool enable1;
   
    //[ConditionalHide(new string[] {"enable1", "enable2"}, new bool[] { true, true },true, true )]
    //public int testInt;

    ////////////////[ConditionalHide()]
   
     public  enum TestType { None, Test1, Test2, Test3 }


    [ConditionalHide(nameof(enable1))]
    public float enable1_f;

    [ConditionalHide(nameof(enable1))]
    public string enable1_str;

    [ConditionalHide(nameof(enable1))]
    public TestClass testClass;


    public bool enable2;

    [ConditionalHide("enable2")]
    public string enable2_str;

    [ConditionalHide("enable2")]
    public float enable2_f;


    //=======Enum===========
    public TestType testType = TestType.None;

   [ConditionalEnumHide(nameof(testType), (int)TestType.None)]
    public string enumHide_str;

   [ConditionalEnumHide(nameof(testType), (int)TestType.None)]
    public float enumHide_f;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [System.Serializable]
    public class TestClass
    {
        public string str;
        public float myFloat;
    }

}
