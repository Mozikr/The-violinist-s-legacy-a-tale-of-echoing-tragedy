using System.Collections;
using UnityEngine;

public class StairsJumpscare : MonoBehaviour
{

    public GameObject _stairsLight;
    public GameObject _lightning;
    public GameObject _audio;
    
    private bool _wasActivated;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player") && !_wasActivated)
        {
            _wasActivated = true;
            StartCoroutine(StartStairsJumpScare());
        }
    }
    
    private IEnumerator StartStairsJumpScare()
    {

        foreach (Transform audioFile in _audio.transform)
        {
            audioFile.gameObject.GetComponent<AudioSource>().Play();
        }
        
        foreach (Transform stairLight in _stairsLight.transform)
        {
            stairLight.GetChild(0).GetChild(0).gameObject.SetActive(true);
        }

        _lightning.SetActive(true);
        yield return new WaitForSeconds(.7f);
        _lightning.SetActive(false);
    }

    private void Update()
    {
        if (_wasActivated)
        {
            foreach (Transform stairLight in _stairsLight.transform)
            {
                stairLight.GetChild(0).GetChild(0).gameObject.GetComponent<Light>().intensity += Random.Range(-.1f, .1f);
            }
        }
    }
}
