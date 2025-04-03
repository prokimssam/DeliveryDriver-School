using UnityEngine;

public class House
{
    public string tv = "거실 TV";
    private string diary = "비밀 다이어리";
    protected string secretKey = "집 비밀번호";

    public string GetDiary()
    {
        Driver driver = new Driver();
        //driver.moveSpeed = 1;

        return diary;
    }
}
