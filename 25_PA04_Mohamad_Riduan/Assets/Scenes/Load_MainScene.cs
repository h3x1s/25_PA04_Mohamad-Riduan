using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_MainScene : MonoBehaviour
{
    public string SceneToLoad = "";
    public float DelayTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Wait");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(DelayTime);
        SceneManager.LoadScene("MainScene");
    }
}
