namespace Task2.MES.Domain;

// 定義產品批次的狀態
public enum LotStatus 
{ 
    Waiting,    // 等待加工
    Processing, // 加工中
    Finished,   // 已完成
    Hold        // 暫停中
}

// 定義生產設備的狀態
public enum EquipmentStatus 
{ 
    Idle,        // 閒置
    Running,     // 運作中
    Down,        // 故障
    Maintenance  // 保養中
}