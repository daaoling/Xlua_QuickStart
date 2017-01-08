using UnityEngine;
using System.Collections;
using XLua;

public class mTest : MonoBehaviour {
    
    LuaEnv luaenv = null;
    // Use this for initialization
    void Start()
    {
        luaenv = new LuaEnv();
        luaenv.DoString("require 'test'");
    }

    // Update is called once per frame
    void Update()
    {
        if (luaenv != null)
        {
            luaenv.Tick();
        }
    }

    void OnDestroy()
    {
        luaenv.Dispose();
    }

    
}
