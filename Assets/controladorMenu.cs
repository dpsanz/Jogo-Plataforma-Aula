using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class controladorMenu : MonoBehaviour
{
    private UIDocument document;
    private Button botao;

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        botao = document.rootVisualElement.Q<Button>("btnjogar");
        botao.RegisterCallback<ClickEvent>(onPlay);
        botao = document.rootVisualElement.Q<Button>("btnoptions");
        botao.RegisterCallback<ClickEvent>(onOpt);
    }

    void onPlay(ClickEvent evt)
    {
        SceneManager.LoadScene("Main");  
    }
    void onOpt(ClickEvent evt)
    {
        SceneManager.LoadScene("Options");
    }
}
