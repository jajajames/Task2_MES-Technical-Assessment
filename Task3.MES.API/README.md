# Task 3: MES Web API Implementation

## 專案概述
本專案為 MES 系統的後端 API 門面，負責處理前端請求並與 Task 2 定義的領域模型 (Domain Models) 進行互動。目前已實作基礎的資料查詢功能，支援 JSON 格式輸出。

## 系統架構
- **開發框架**：ASP.NET Core Web API (.NET 6.0/7.0+)
- **相依性**：引用 `Task2.MES.Domain` 專案作為核心邏輯層。
- **資料儲存**：目前使用記憶體暫存 (In-Memory Static List) 模擬資料庫運作。

## API 介面規格 (API Endpoints)

### 1. 產品批次管理 (Lots)
- **GET /api/lots**：取得工廠內所有產品批次的清單與狀態。
- **POST /api/lots** (開發中)：建立新的產品生產批次。

### 2. 設備管理 (Equipment)
- **GET /api/equipment**：查詢目前所有機台的運行狀態（如 Idle, Productive）。

## 技術重點
- **專案解耦 (Decoupling)**：透過 `dotnet add reference` 引用 Domain 層，實現「設計規範」與「實作門面」的分離。
- **RESTful 設計**：遵循標準 HTTP 語義，回傳正確的狀態碼 (如 200 OK, 404 Not Found)。
- **自動化序列化**：利用 .NET 內建工具將 C# 物件自動轉換為網頁通用的 JSON 格式。

## 如何執行
1. 確保已安裝 .NET SDK。
2. 進入專案目錄：`cd Task3.MES.API`
3. 執行指令：`dotnet run`
4. 開啟瀏覽器訪問：`http://localhost:5269/api/lots`