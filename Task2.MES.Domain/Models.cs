namespace Task2.MES.Domain;

/// <summary>
/// 產品批次模型 (Lot)：代表工廠中移動的實體貨物
/// 想像成貼在 Wafer Box 上的那一張數位標籤
/// </summary>
public class Lot
{
    /// <summary> 批次唯一識別碼 (例如: LOT20240501001) </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary> 產品類型 (例如: Wafer, Frame, Substrate) </summary>
    public string ProductType { get; set; } = string.Empty;

    /// <summary> 此批次的數量 (例如: 25 單位) </summary>
    public int Quantity { get; set; }

    /// <summary> 
    /// 產品當前狀態 (引用自 LotStatus Enum) 
    /// 預設值為 Waiting (等待中)
    /// </summary>
    public LotStatus Status { get; set; } = LotStatus.Waiting;
}

/// <summary>
/// 設備模型 (Equipment)：代表工廠中的實體生產機台
/// 用來記錄機台的硬體資訊與即時狀態
/// </summary>
public class Equipment
{
    /// <summary> 設備編號 (例如: EQP-LIT-01) </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary> 設備名稱 (例如: 黃光機 1 號) </summary>
    public string Name { get; set; } = string.Empty;
    
    public EquipmentStatus CurrentStatus { get; set; }
    /// <summary> 
    /// 設備當前運行狀態 (引用自 EquipmentStatus Enum)
    /// 預設值為 Idle (閒置中)
    /// </summary>
    public EquipmentStatus Status { get; set; } = EquipmentStatus.Idle;
}