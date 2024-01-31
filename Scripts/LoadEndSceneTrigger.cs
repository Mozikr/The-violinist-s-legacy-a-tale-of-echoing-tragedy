using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEndSceneTrigger : MonoBehaviour
{
    public GameObject _actionKey;
    public bool _isEnabled;
    private bool _isClose;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _isClose = true;
            _actionKey.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _isClose = false;
            _actionKey.SetActive(false);
        }
    }

    private void Update()
    {
        if (_isClose && Input.GetButtonDown("Action") && _isEnabled)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
