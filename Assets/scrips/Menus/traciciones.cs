using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class traciciones : MonoBehaviour
{
    private Animator _transicionanim;
    // Start is called before the first frame update
    void Start()
    {
        _transicionanim = GetComponent<Animator>();
    }

    public void loadscene(string scene)
    {
        StartCoroutine(Transiciona(scene));
    }
    IEnumerator Transiciona(string scene)
    {
        _transicionanim.SetTrigger("salida");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(scene);
    }
}
