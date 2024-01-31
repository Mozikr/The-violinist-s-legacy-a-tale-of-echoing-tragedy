using System.Collections;
using UnityEngine;

public class StatueSequence : MonoBehaviour
{
    public Camera _mainCamera;
    public Camera _statueCamera;
    public Item _nonRequiredItem;
    public GameObject _flap;
    public GameObject _statue;
    public GameObject _fade;

    private bool _sequenceStarted;
    private AudioSource _audioSource;
    
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        Inventory inventory = Inventory.instance;
        if (!_sequenceStarted && (inventory.items.Contains(_nonRequiredItem) && inventory.items.Count == 6
            || !inventory.items.Contains(_nonRequiredItem) && inventory.items.Count == 5))
        {
            _sequenceStarted = true;
            StartCoroutine(StartStatueSequence());
            
        }
    }

    IEnumerator StartStatueSequence()
    {
        yield return new WaitForSeconds(7f);
        _fade.GetComponent<FadeIn>().StartFade();
        yield return new WaitForSeconds(2f);
        _statueCamera.gameObject.SetActive(true);
        _mainCamera.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
       _fade.GetComponent<FadeIn>().StartFadeOut();
        
        yield return new WaitForSeconds(3f);
        _audioSource.Play();
        yield return new WaitForSeconds(1f);
        _statue.GetComponent<Animator>().Play("StatuAnimNew");
        yield return new WaitForSeconds(4f);
        _flap.GetComponent<LoadEndSceneTrigger>()._isEnabled = true;
        
        _fade.GetComponent<FadeIn>().StartFade();
        yield return new WaitForSeconds(2f);
        _mainCamera.gameObject.SetActive(true);
        _statueCamera.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        _fade.GetComponent<FadeIn>().StartFadeOut();
    }
}
