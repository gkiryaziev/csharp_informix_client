##	Простой пример работы с базой данных IBM Informix, используя ADO.NET.

Показаны основные операции работы с БД:
- соединение с БД;
- получение всех записей;
- добавление новых записей;
- обновление записей;
- удаление записей.

Структура базы данных.

```
create table 'informix'.phonebook (
    id SERIAL not null,
    phone VARCHAR(100),
    person VARCHAR(100),
    street VARCHAR(100),
    building VARCHAR(100),
    appartment VARCHAR(100)
)
extent size 32 next size 32
lock mode page;
```