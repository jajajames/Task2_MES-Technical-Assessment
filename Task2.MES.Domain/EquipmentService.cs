namespace Task2.MES.Domain;

// 這裡就是「實作」你的合約
public class EquipmentService : IEquipmentService
{
    public void UpdateStatus(string id, EquipmentStatus newStatus)
    {
        // 模擬驗證邏輯
        Console.WriteLine($"[驗證成功] 機台 {id} 狀態已更新為 {newStatus}");
    }

    public Equipment? GetEquipmentById(string id)
    {
        // 模擬回傳一個測試資料
        return new Equipment { Id = id, Name = "測試機台" };
    }
}