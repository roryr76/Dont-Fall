using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler, IPointerClickHandler
{
    private new Rigidbody rigidbody;
    public Sprite Default;
    public Sprite Active;
    private Image Image;
    private SceneManager SM;
    // Start is called before the first frame update
    void Start()
    {
        Image = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Image.sprite = Active;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Image.sprite = Default;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        LoadScene("SampleScene");
    }

    private void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


}
