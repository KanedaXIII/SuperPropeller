namespace Code
{
    public interface IMovable

    {
    void DoMove(float linearSpeed);
    void UpdateRailFollowerPosition(float linearSpeed);
    void DoRotate(float angularSpeed);
    }
}