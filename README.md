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

## 🛠️ Технологии

- ASP.NET Core Web API
- In-memory коллекции
- Swagger UI


 var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
 var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
 options.IncludeXmlComments(xmlPath);

});
