using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayrHP : MonoBehaviour
{
    [SerializeField] private float maxHP;
    [SerializeField] private Image HPBar;

    float n;
    private void Start()
    {
        n = maxHP;
    }
    public void DPSPlayer(float dps)
    {
        n = n - dps;
        HPBar.fillAmount = n / 100;
        if (n <= 0)
        {
            SceneManager.LoadScene("0");
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
