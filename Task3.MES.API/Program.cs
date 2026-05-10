var builder = WebApplication.CreateBuilder(args);

// --- [服務註冊區] ---

// 註冊 OpenAPI (Swagger) 支援，這能自動生成 API 文件
builder.Services.AddOpenApi();

// 【核心修正】：註冊控制器服務。
// 這行會讓系統去尋找專案中所有繼承自 ControllerBase 的類別 (例如你的 LotsController)
builder.Services.AddControllers(); 

var app = builder.Build();

// --- [中間件與路由設定區] ---

// 如果是開發環境，開啟 OpenAPI 的端點
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// 自動將 HTTP 請求轉向為更安全的 HTTPS
app.UseHttpsRedirection();

// 【核心修正】：將網址路徑映射到控制器上。
// 當你在網址輸入 /api/lots 時，就是靠這行「地圖」導向 LotsController 的
app.MapControllers(); 

// 【註：已移除原本的 WeatherForecast 範例程式碼】
// 因為我們要專注於 MES 系統的 Lots 與 Equipment 管理，不需要氣象預報的假資料。

// 正式啟動伺服器，開始監聽請求
app.Run();