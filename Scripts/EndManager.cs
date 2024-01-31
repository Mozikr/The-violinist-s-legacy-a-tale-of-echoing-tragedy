using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
{
    public GameObject _theEnd;
    public GameObject _theEndText;

    private void Start()
    {
        StartCoroutine(PlayText());
    }

    IEnumerator PlayText()
    {
  
        _theEndText.SetActive(true);
        yield return new WaitForSeconds(30f);
        _theEndText.SetActive(false);
        yield return new WaitForSeconds(1f);
        _theEnd.SetActive(true);
        yield return new WaitForSeconds(3f);
        _theEnd.SetActive(false);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Menu");
    }
}
