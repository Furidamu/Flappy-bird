using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Scene : MonoBehaviour
{
    public void Restartlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // перезагрузка сцены (но это я чет запарился)

        // можно было написать вот так: SceneManager.LoadScene(0) - тот же эффект
    }

}
