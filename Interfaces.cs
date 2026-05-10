namespace Task2.MES.Domain;

/// <summary>
/// 產品批次服務的「規格契約」
/// 只要是自稱「批次管理器」的程式，都必須實現以下功能
/// </summary>
public interface ILotService
{
    /// <summary>
    /// 功能：建立一個新的生產批次 (Lot)
    /// 參數：傳入一個 Lot 物件資料
    /// </summary>
    void CreateLot(Lot lot);

    /// <summary>
    /// 功能：根據 ID 查詢特定的批次資訊
    /// 回傳：找到就回傳 Lot 物件，找不到則回傳 null (?)
    /// </summary>
    Lot? GetLotById(string id);
}

/// <summary>
/// 設備服務的「規格契約」
/// 規定了所有與「實體機台」溝通時必須具備的基本動作
/// </summary>
public interface IEquipmentService
{
    /// <summary>
    /// 功能：更新指定機台的運作狀態 (例如：從 Idle 改為 Productive)
    /// 參數：機台 ID, 想要變更的新狀態
    /// </summary>
    void UpdateStatus(string id, EquipmentStatus newStatus);

    /// <summary>
    /// 功能：根據 ID 取得機台目前的詳細資訊 (名稱、當前狀態等)
    /// </summary>
    Equipment? GetEquipmentById(string id);
}