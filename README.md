# Рекламный сервис (AdPlatformService)

## 📌 Описание

Веб-сервис на ASP.NET Core Web API, который позволяет подбирать рекламные площадки по заданной локации.  
Данные загружаются из текстового файла и хранятся в оперативной памяти.

## 🚀 Запуск проекта

1. Установите [.NET SDK 6.0+](https://dotnet.microsoft.com/download)
2. Клонируйте репозиторий: git clone https://github.com/ВАШ_ЮЗЕРНЕЙМ/AdPlatformService.git cd AdPlatformService
3. Запустите проект: dotnet run
4. Откройте Swagger UI:  
[http://localhost:5000/swagger](http://localhost:5000/swagger)

## 📂 Пример входного файла

Яндекс.Директ:/ru 
Ревдинский рабочий:/ru/svrd/revda,/ru/svrd/pervik 
Газета уральских москвичей:/ru/msk,/ru/permobl,/ru/chelobl 
Крутая реклама:/ru/svrd

## 📡 API эндпоинты

### 🔄 Загрузка файла

`POST /api/adplatform/upload`  
Загружает текстовый файл с площадками.  
Формат: `multipart/form-data`, поле `file`.

### 🔍 Поиск площадок

`GET /api/adplatform/search?location=/ru/svrd/revda`  
Возвращает список площадок, действующих в указанной локации.

## ✅ Юнит-тесты

Проект содержит тесты для проверки загрузки и поиска.  
Запуск: dotnet test

## 🛠️ Технологии

- ASP.NET Core Web API
- In-memory коллекции
- Swagger UI
- xUnit (тесты)

## 📤 Публикация на GitHub

1. Инициализируйте репозиторий:
git init 
git add . 
git commit -m "Initial commit"
2. Создайте репозиторий на [GitHub](https://github.com)
3. Добавьте удалённый репозиторий:

git remote add origin https://github.com/ВАШ_ЮЗЕРНЕЙМ/AdPlatformService.git 
git push -u origin master

---

## 🌐 Swagger — русификация

В `Program.cs` добавь:

```csharp
builder.Services.AddSwaggerGen(options =>
{
 options.SwaggerDoc("v1", new OpenApiInfo
 {
     Title = "Рекламный сервис",
     Description = "API для загрузки и поиска рекламных площадок по регионам",
     Version = "v1"
 });

 var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
 var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
 options.IncludeXmlComments(xmlPath);
});