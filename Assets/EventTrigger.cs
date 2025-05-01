using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventTrigger : MonoBehaviour
{
    public string sceneName;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // if player hits object  
        
        if (other.gameObject.tag == "Player")
        {
            
            
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);

        }
    }
}
