using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton03 : MonoBehaviour
{
    public void Retry() {
        SceneManager.LoadScene (3);
    }
}
