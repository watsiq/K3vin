using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIController : MonoBehaviour
{
    public GameObject[] navigationPanels;
    public GameObject nextButton;
    public GameObject prevButton;
    public GameObject menuPanel;
    public GameObject informationMenu;
    public GameObject informationPanel;

    private int index;

    private void Start()
    {
        index = 0;
    }

    public void StartHandler()
    {
        menuPanel.SetActive(false);
        //action start
    }

    public void OpenPanel(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void Next()
    {
        index++;

        if (index > 0)
        {
            prevButton.SetActive(true);
        }

        if (index == navigationPanels.Length - 1)
        {
            nextButton.SetActive(false);
        }

        navigationPanels[index].SetActive(true);
        navigationPanels[index - 1].SetActive(false);
    }

    public void Prev()
    {
        index--;

        if (index != navigationPanels.Length - 1)
        {
            nextButton.SetActive(true);
        }

        if (index == 0)
        {
            prevButton.SetActive(false);
        }

        navigationPanels[index].SetActive(true);
        navigationPanels[index + 1].SetActive(false);
    }
}
