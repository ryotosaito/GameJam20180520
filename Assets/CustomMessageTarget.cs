using UnityEngine.EventSystems;

public interface ICustomMessageTarget : IEventSystemHandler
{
    // メッセージングシステムを通して呼び出される関数
    void Message1();
}