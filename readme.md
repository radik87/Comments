## Бекенд инструкция

Пойдите в `backend\GuestBook\GuestBook\appsettings.json` и установите правильный DefaultConnection.

Откройте солюшен GuestBook и нажмите f5. Vs попытается открыть станицу, но она не загрузится. Это Ок, работают только апи.

Скопируйте ваш адрес сайта, у меня `https://localhost:44335`.

На вашем компютере так же должен быть установлен MS SQL Server 2016 или поздней версии.

## Фронденд инструкция

В командной строке:

`npm install`.

Убедитесь что в методах fetch и сервисе apiRoute.js тот же номер порта `https://localhost:44335/api/comments`.

`npm run serve`.


