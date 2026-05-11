using Task2.MES.Domain;

Console.WriteLine("========== MES 系統完整邏輯驗證開始 ==========");

// 1. 準備服務
IEquipmentService eqService = new EquipmentService();

// 2. 測試：正常更新流程 (驗證 Enum 與 Interface 串接)
Console.WriteLine("\n[情境一] 正常機台狀態更新：");
eqService.UpdateStatus("EQ-001", EquipmentStatus.Productive);

// 3. 測試：Model 讀取 (驗證 Model 的資料裝載)
Console.WriteLine("\n[情境二] 查詢現有機台資訊：");
var eq = eqService.GetEquipmentById("EQ-001");
if (eq != null)
{
    Console.WriteLine($"-> 驗證成功：從 Model 取得名稱為 {eq.Name}");
}

// 4. 測試：邊界與異常 (驗證 Nullable ? 的邏輯)
Console.WriteLine("\n[情境三] 查詢不存在的機台 ID：");
var fakeEq = eqService.GetEquipmentById("ERROR-ID");
if (fakeEq == null)
{
    Console.WriteLine("-> 驗證成功：系統能正確識別無效 ID 並回傳 Null (防呆處理)。");
}

Console.WriteLine("\n========== 驗證完成：Domain 層邏輯穩定 ==========");