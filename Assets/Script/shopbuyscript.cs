using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
public class shopbuyscript : MonoBehaviour
{
    int cost = 5;

    public void HealthUpgrade()
    {
        //코드 작성 해주세요!
        if (GameManager.instance.coin >= cost)
        {
            GameManager.instance.coin -= cost;
            GameManager.instance.player_maxhp++;
        }
    }

    public void AttackPowerUpgrade()
    {
        //코드 작성 해주세요!
        if (GameManager.instance.coin >= cost)
        {
            GameManager.instance.coin -= cost;
            GameManager.instance.bulletdamage++;
        }       
    }

    public void maxammoUpgrade()
    {
        //코드 작성 해주세요!
        if (GameManager.instance.coin >= cost)
        {
            GameManager.instance.coin -= cost;
            GameManager.instance.maxammo++;
        }
    }

    public void MoveNextStage()
    {
        FadeManager.Instance.LoadScene("beforestage");
    }
}
