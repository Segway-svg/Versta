# WebApplication3

Загрузил то, что успел сделать, буду обновлять по мере дальнейшей реализации. Проект был выполнен на VS. Для запуска необходимо установить следующие библиотеки:

1) Microsoft.EntityFrameworkCore
2) Microsoft.EntityFrameworkCore.SqlServer
3) Microsoft.EntityFrameworkCore.Tools

В качестве базы данных используется MS SqlServer. Таблица создаётся при помощи миграции (Add-Migration "InitialCreate" и Update-Database)

Приложение слева делает запрос к API серверу и выполняет его CRUD команды. На да данном примере происходит процесс отображения уже созданных записей. На скриншоте можно заметить, что запросы были выполнены и отработаны корректно: 
![image](https://github.com/Segway-svg/Versta/assets/62465966/e680c684-8a86-475a-be7e-3ed7b7872d7b)

Также сделана отдельная форма для создания заказов. Здесь учитывается условие, что атрибуты должны быть обязательны к заполнению:
![image](https://github.com/Segway-svg/Versta/assets/62465966/027c9a1c-615b-4aa5-bb7e-93f621705ec9)

