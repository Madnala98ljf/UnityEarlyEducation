using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelAsync : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Load",2);
    }

    void Load() {
        SceneManager.LoadScene("main");
    }
}
