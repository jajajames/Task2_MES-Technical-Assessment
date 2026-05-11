using Microsoft.AspNetCore.Mvc;
using Task2.MES.Domain; // 引用你在 Task 2 定義的領域模型 (Lot, LotStatus 等)

namespace Task3.MES.API.Controllers;

/// <summary>
/// 產品批次 (Lot) 控制器：負責處理所有關於產品批次的網路請求
/// </summary>
[ApiController] // 標記此類別為 Web API 控制器，會自動啟用模型驗證功能
[Route("api/[controller]")] // 設定網址路徑，[controller] 會自動帶入類別名稱，因此網址為 /api/lots
public class LotsController : ControllerBase
{
    // 使用靜態清單 (Static List) 模擬資料庫存儲空間 (Mock Data)
    // 這裡必須嚴格遵守你在 Models.cs 裡定義的屬性名稱：Id 與 ProductType
    private static List<Lot> _lots = new List<Lot>
    {
        new Lot { Id = "LOT-001", ProductType = "Wafer", Quantity = 100, Status = LotStatus.Waiting },
        new Lot { Id = "LOT-002", ProductType = "Frame", Quantity = 50, Status = LotStatus.Running }
    };

    /// <summary>
    /// 功能：取得目前系統中所有的產品批次資料
    /// 對應動作：GET /api/lots
    /// </summary>
    /// <returns>回傳 HTTP 200 OK 以及 JSON 格式的產品清單</returns>
    [HttpGet] // 標記此方法負責處理 HTTP GET 請求
    public ActionResult<IEnumerable<Lot>> GetAll()
    {
        // Ok() 是 ControllerBase 提供的輔助方法，會回傳 200 狀態碼
        // 並自動將 C# 物件轉換為網頁通用的 JSON 格式
        return Ok(_lots);
    }
}