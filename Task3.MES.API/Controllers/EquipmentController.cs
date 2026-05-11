using Microsoft.AspNetCore.Mvc;
using Task2.MES.Domain; // 引用你在 Task 2 設計的 Domain 模型 (包含 Equipment 和 EquipmentStatus)

namespace Task3.MES.API.Controllers;

/// <summary>
/// 設備管理控制器：負責處理所有與機台 (Equipment) 相關的網路請求
/// </summary>
[ApiController] // 標記為 Web API，提供自動化的模型驗證與 HTTP 錯誤回應處理
[Route("api/[controller]")] // 設定路由路徑，[controller] 會根據類別名稱自動對應為 /api/equipment
public class EquipmentController : ControllerBase
{
    // 模擬設備資料庫：使用靜態清單 (Static List) 將資料暫存在記憶體 (RAM) 中
    // 注意：這裡的欄位名稱 (Id, Name, Status) 必須與 Task2.MES.Domain 中的 Models.cs 完全對應
    private static List<Equipment> _equipments = new List<Equipment>
    {
        // 預設兩台測試機台：黃光機台 (Lithography) 與 蝕刻機台 (Etching)
        new Equipment { Id = "EQP-01", Name = "Lithography-01", Status = EquipmentStatus.Idle },
        new Equipment { Id = "EQP-02", Name = "Etching-01", Status = EquipmentStatus.Productive }
    };

    /// <summary>
    /// 功能：取得目前工廠內所有設備的清單與狀態
    /// 路由位置：GET http://localhost:5269/api/equipment
    /// </summary>
    /// <returns>回傳 HTTP 200 OK 與 JSON 格式的設備名單</returns>
    [HttpGet] // 標記此方法只處理 HTTP GET (查詢) 請求
    public ActionResult<IEnumerable<Equipment>> GetAll()
    {
        // Ok() 會回傳 200 狀態碼，並將 C# 物件集合序列化 (Serialize) 為 JSON 字串傳給瀏覽器
        return Ok(_equipments);
    }
}