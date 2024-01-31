using UnityEngine;

public class PlayFootsteps : MonoBehaviour
{

    public AudioSource _footSound;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        {
            _footSound.enabled = true;
        }
        else
        {
            _footSound.enabled = false;
        }
    }

}
