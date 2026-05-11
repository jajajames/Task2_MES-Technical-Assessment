var builder = WebApplication.CreateBuilder(args);

// --- [服務註冊區] ---
builder.Services.AddControllers(); 
builder.Services.AddOpenApi();

var app = builder.Build();

// --- [中間件與路由設定區] ---
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        // 連結 .NET 9 產出的 JSON 文件
        options.SwaggerEndpoint("/openapi/v1.json", "Task3.MES.API v1");
    });
}

app.UseHttpsRedirection();
app.MapControllers(); 

app.Run();