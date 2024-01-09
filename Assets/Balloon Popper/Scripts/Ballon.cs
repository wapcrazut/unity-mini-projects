using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour
{
    [SerializeField]
    int scoreToGive;
    [SerializeField]
    int clicksToPop;
    [SerializeField]
    float sizeIncrease = .2f;

    ScoreManager scoreManager;
    Material material;
    Color originalColor;

    void Awake()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        material = GetComponent<MeshRenderer>().material;
        originalColor = material.color;
    }

    void OnMouseDown()
    {
        clicksToPop--;
        material.color = Color.white;
        transform.localScale += Vector3.one * sizeIncrease;

        if (clicksToPop == 0)
        {
            scoreManager.IncreaseScore(scoreToGive);
            Destroy(gameObject);
        }
    }

    private void OnMouseUp()
    {
        material.color = originalColor;
    }
}
