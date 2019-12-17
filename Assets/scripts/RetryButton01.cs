using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton01 : MonoBehaviour
{
    public void Retry() {
        SceneManager.LoadScene (1);
    }
}
