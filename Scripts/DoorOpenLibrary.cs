using UnityEngine;

public class DoorOpenLibrary : MonoBehaviour
{
    private bool _isClose;
    public GameObject _actionKey;
    public Animator _anim;
    public GameObject _collider;
    public GameObject _audio;
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
        if (_isClose == true && Input.GetButtonDown("Action"))
        {
            _audio.SetActive(true);
            _anim.Play("AnimDoorLibrary");
            _actionKey.SetActive(false);
            _collider.SetActive(false);
        }
    }

}
