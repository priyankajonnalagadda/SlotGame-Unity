
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Reel[] reels;

    public void Spin()
    {
        foreach (Reel reel in reels)
        {
            reel.StartSpin();
        }
        Invoke(nameof(CheckWin), 1f);
    }

    void CheckWin()
    {
        int first = reels[0].GetResult();
        bool isWin = true;

        foreach (Reel reel in reels)
        {
            if (reel.GetResult() != first)
            {
                isWin = false;
                break;
            }
        }

        Debug.Log(isWin ? "YOU WIN!" : "TRY AGAIN");
    }
}
