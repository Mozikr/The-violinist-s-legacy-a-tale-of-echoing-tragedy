using System.Collections;
using UnityEngine;

public class PushObjectsKitchen : MonoBehaviour
{
    public Rigidbody _pumpkin1;
    public Rigidbody _pumpkin2;
    public Rigidbody _pumpkin3;

    public Rigidbody _mushroom1;
    public Rigidbody _mushroom2;
    public Rigidbody _mushroom3;

    public Rigidbody _bread1;
    public Rigidbody _bread2;
    public Rigidbody _bread3;

    public Rigidbody _shelf;

    public GameObject _light;

    public Rigidbody _tomatos1;
    public Rigidbody _tomatos2;
    public Rigidbody _tomatos3;

    public Rigidbody _pan1;
    public Rigidbody _pan2;

    public Animator _anim;

    public Animator _potAnim;
     public AudioSource _audio;

    public GameObject _colider;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(ThrowObjects());
        }

    }

    IEnumerator ThrowObjects()
    {
        _audio.Play();
        _pumpkin1.AddForce(Vector3.right * 20, ForceMode.Impulse);
        _pumpkin2.AddForce(Vector3.right * 20, ForceMode.Impulse);
        _pumpkin3.AddForce(Vector3.right * 20, ForceMode.Impulse);

        _mushroom1.AddForce(Vector3.right * 20, ForceMode.Impulse);
        _mushroom2.AddForce(Vector3.right * 20, ForceMode.Impulse);
        _mushroom3.AddForce(Vector3.right * 20, ForceMode.Impulse);

        _bread1.AddForce(Vector3.right * 20, ForceMode.Impulse);
        _bread2.AddForce(Vector3.right * 20, ForceMode.Impulse);
        _bread3.AddForce(Vector3.right * 20, ForceMode.Impulse);

        _shelf.AddForce(-Vector3.forward * 8, ForceMode.Impulse);

        _light.SetActive(true);

        _tomatos1.AddForce(Vector3.right * 20, ForceMode.Impulse);
        _tomatos2.AddForce(Vector3.right * 20, ForceMode.Impulse);
        _tomatos3.AddForce(Vector3.right * 20, ForceMode.Impulse);

        _pan1.AddForce(Vector3.right * 20, ForceMode.Impulse);
        _pan2.AddForce(Vector3.right * 20, ForceMode.Impulse);

        _anim.Play("ChestAnim");
        _potAnim.Play("PotAnim");
        yield return new WaitForSeconds(1f);
        _colider.SetActive(false);
    }
}
