using UnityEngine;

public class House
{
    public string tv = "�Ž� TV";
    private string diary = "��� ���̾";
    protected string secretKey = "�� ��й�ȣ";

    public string GetDiary()
    {
        Driver driver = new Driver();
        //driver.moveSpeed = 1;

        return diary;
    }
}
