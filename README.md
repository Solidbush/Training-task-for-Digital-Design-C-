# Вступительное задание
---
## Задание №1:
### Описание:
> Дана БД, имеющая  две таблицы: сотрудники и подразделение.
Необходимо написать 4 запроса:
1. Сотрудника с максимальной заработной платой
2. Вывести одно число: максимальную длину цепочки руководителей по таблице сотрудников (вычислить глубину дерева)
3. Отдел, с максимальной суммарной зарплатой сотрудников
4. Сотрудника, чье имя начинается на «Р» и заканчивается на «н»
---
## Создание таблиц:
```SQL
CREATE TABLE Departament (
ID INTEGER NOT NULL PRIMARY KEY,
"Name" VARCHAR 
);

CREATE TABLE Employee (
ID INTEGER NOT NULL PRIMARY KEY,
Departament_Id INTEGER REFERENCES Departament(ID),
Cheief_id INTEGER REFERENCES Employee(ID),
"Name" VARCHAR,
Salary INTEGER
) 
```

## Запрос №1:
```SQL
SELECT TOP 1 [EMPLOYEE].[NAME] AS [Name]
FROM [EMPLOYEE]
ORDER BY [EMPLOYEE].[SALARY] DESC
```

## Запрос №2:
```SQL
https://eemojis.ru/wp-content/uploads/2020/05/pensive-face-microsoft.png
```

## Запрос №3:
```SQL
SELECT TOP 1 dp.[ID] AS [Id]
FROM [DEPARTMENT] as dp JOIN EMPLOYEE AS emp
ON dp.[ID] = emp.[ID]
GROUP BY dp.[ID]
ORDER BY sum(emp.[SALARY]) DESC
```

## Запрос №4:
```SQL
SELECT TOP 1 [EMPLOYEE].[NAME] AS [Name]
FROM EMPLOYEE
WHERE [EMPLOYEE].[NAME] like 'Р%н'
```

---

## Задание №2
### Описание: 
> Напишите консольное приложение на C#, которое на вход принимает большой текстовый файл (например «Война и мир», можно взять отсюда [ссылка](http://az.lib.ru/)).   
> На выходе создает текстовый файл с перечислением всех уникальных слов встречающихся в тесте и количеством их употреблений, отсортированный в порядке убывания количества употреблений, например:   
d'artifice 50   
говорит 48   
значительно 30   

---

### Задание выполнил [Гаврилов Алексей](https://github.com/Solidbush)