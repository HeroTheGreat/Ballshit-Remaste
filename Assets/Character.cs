using UnityEngine;

public class Character : MonoBehaviour
{
    private int column;
    private int row;
    private float gap;

    public void Init(int column, int row, float gap)
    {
        this.column = column;
        this.row = row;
        this.gap = gap;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) transform.position += Vector3.right * gap;
        if (Input.GetKeyDown(KeyCode.LeftArrow)) transform.position += Vector3.left * gap;
        if (Input.GetKeyDown(KeyCode.UpArrow)) transform.position += Vector3.up * gap;
        if (Input.GetKeyDown(KeyCode.DownArrow)) transform.position += Vector3.down * gap;

        PositionClamp();
    }

    private void PositionClamp()
    {
        Vector3 position = transform.position;
        float x = Mathf.Clamp(position.x, 0f, row * gap);
        float y = Mathf.Clamp(position.y, 0f, column * gap);
        float z = position.z;
        transform.position = new Vector3(x, y, z);
    }
}