# Task 2: Domain Modeling & Documentation (v2.2)

## 任務概述
本階段目標是建立 MES (製造執行系統) 的核心領域模型 (Domain Model)，並透過 C# 語言特性確保資料的一致性與系統的可擴充性。

## 更新內容 (v2.2 - Documentation Optimization)
在本次更新中，我們針對所有核心零件進行了「文件化」處理，確保系統邏輯透明且易於維護：

### 1. 核心模型 (Models)
- **Lot (產品批次)**：定義了產品在工廠移動時必須攜帶的身份資訊（ID、類型、數量、狀態）。
- **Equipment (生產設備)**：定義了機台的實體屬性與即時運作數據。

### 2. 狀態規範 (Enums)
- 使用 `enum` 強制規範了產品與設備的「生命週期狀態」，避免字串輸入錯誤導致的系統異常（防呆機制）。
    - **LotStatus**: Waiting, Running, Finished, Scrapped.
    - **EquipmentStatus**: Idle, Productive, Down, Maintenance.

### 3. 服務契約 (Interfaces)
- 定義了 `ILotService` 與 `IEquipmentService` 介面。
- **解耦設計**：API 僅需面向介面開發，未來可隨時抽換底層資料庫實作而不影響業務邏輯。

## 技術重點
- **XML 註解**：採用標準的 `/// <summary>` 標籤，支援開發工具自動提示與技術文檔生成。
- **封裝性**：物件屬性均具備完整的型別定義，強化 SQA 驗證時的資料完整性。
