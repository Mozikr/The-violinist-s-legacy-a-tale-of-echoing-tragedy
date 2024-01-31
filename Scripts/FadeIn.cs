using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    private Image _image;
    private bool _fadeEnabled;
    private bool _fadeOutEnabled;

    private void Start()
    {
        _image = GetComponent<Image>();
    }

    public void StartFade()
    {
        _fadeEnabled = true;
    }
    public void StartFadeOut()
    {
        _fadeOutEnabled = true;
    }

    public void FixedUpdate()
    {
        if (_fadeEnabled)
        {
            Color color = _image.color;
            color.a += 0.009f;
            _image.color = color;
            if (_image.color.a >= 1)
                _fadeEnabled = false;
        }
        else if (_fadeOutEnabled)
        {
            Color color = _image.color;
            color.a -= 0.009f;
            _image.color = color;
            if (_image.color.a <= 0)
                _fadeOutEnabled = false;
        }
    }
}
