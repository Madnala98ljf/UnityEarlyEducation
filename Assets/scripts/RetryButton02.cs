using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton02 : MonoBehaviour
{
    public void Retry() {
        SceneManager.LoadScene (2);
    }
}
