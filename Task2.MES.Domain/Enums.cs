namespace Task2.MES.Domain;

/// <summary>
/// 定義產品批次 (Lot) 的生命週期狀態
/// </summary>
public enum LotStatus 
{ 
    /// <summary> 等待中：批次已建立，正等待機台領料 (對應數值: 0) </summary>
    Waiting, 

    /// <summary> 執行中：機台正在加工處理此批次 (對應數值: 1) </summary>
    Running, 

    /// <summary> 已完成：加工結束，等待下一個工序或入庫 (對應數值: 2) </summary>
    Finished, 

    /// <summary> 已報廢：加工過程中發生異常，此批次不可再使用 (對應數值: 3) </summary>
    Scrapped 
}

/// <summary>
/// 定義生產設備 (Equipment) 的即時運作狀態
/// </summary>
public enum EquipmentStatus 
{ 
    /// <summary> 空閒：設備運作正常，目前沒有加工任務 (對應數值: 0) </summary>
    Idle, 

    /// <summary> 生產中：設備正在運行加工任務 (對應數值: 1) </summary>
    Productive, 

    /// <summary> 故障：設備發生異常，暫時無法生產 (對應數值: 2) </summary>
    Down, 

    /// <summary> 保養：設備正在進行預防性維護 (對應數值: 3) </summary>
    Maintenance 
}