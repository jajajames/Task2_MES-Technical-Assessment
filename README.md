# MES 系統技術考核專案

本專案包含 MES 核心邏輯與 Web API 的實作，採用 Monorepo 結構管理。

## 專案結構
- **Task2.MES.Domain**: 核心領域模型，包含批號 (Lot) 與機台 (Equipment) 的模型定義。
- **Task3.MES.API**: 基於 .NET 6/8 實作的 Web API，已成功整合 Task 2 邏輯。

## 目前進度 (task3.1)
- [x] 實作 `LotsController`：提供 GET (取得清單) 與 POST (新增批號) 功能。
- [x] 環境治理：已移除編譯產生的 `bin/obj` 暫存檔，並加入 `.gitignore`。
- [x] 跨專案引用：API 專案已成功連結 Domain 專案。

## 如何執行
1. `cd Task3.MES.API`
2. `dotnet run`
3. 瀏覽 `http://localhost:5269/swagger` 進行 API 測試