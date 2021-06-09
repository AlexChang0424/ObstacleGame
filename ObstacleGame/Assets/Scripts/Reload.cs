using UnityEngine;
using UnityEngine.SceneManagement; 

public class Reload : MonoBehaviour
{
    float loadDelay = .5f;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
            Invoke("ReloadLVL",loadDelay);
        }
    }

    void ReloadLVL()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Reload");
    }
}

    
