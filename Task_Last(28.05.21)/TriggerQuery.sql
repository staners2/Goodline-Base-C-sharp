CREATE TRIGGER Order_InsteadOf_Delete
ON [dbo].[ORDER]
INSTEAD OF DELETE 
as 
DECLARE 
@id int = (select id_order from [deleted])
UPDATE [ORDER]
SET IsDelete = 1
WHERE id_order =(SELECT id_order FROM deleted)

UPDATE [PRODUCT_LIST]
SET IsDelete = 1
WHERE id_order =(SELECT id_order FROM deleted)

INSERT into [dbo].[HistroryActions] 
VALUES ('Удаление заказа | ID:'+STR(@id),GetDate())


CREATE TRIGGER Product_After_Delete
ON [dbo].[PRODUCT]
AFTER DELETE 
AS
DECLARE 
@name nvarchar(64) = (select name from [deleted]),
@male_female nvarchar(1) = (select male_female from [deleted]),
@price money = (select price from [deleted])

INSERT into [HistoryActions]
VALUES ('Удаление продукта | Имя:'+STR(@name)+' | Пол: '+STR(@male_female)+' | Стоимость: '+STR(@price),GetDate())


CREATE TRIGGER Client_After_Update
ON [dbo].[CLIENT] -- inserted | deleted
AFTER UPDATE
AS 
DECLARE 
@id int = (select id_client from [deleted]),
@name nvarchar(64) = (select name_client from [deleted]),
@surname nvarchar(64) = (select surname_client from [deleted]),
@patronymic nvarchar(64) = (select patronymic_client from [deleted]),
@number nvarchar(20) = (select number_client from [deleted])

INSERT into [dbo].[HistroryActions] 
VALUES ('Обновление клиента |ID:'+STR(@id)+'|Имя:'+@name+'|Фамилия:'+@name+'|Отчество:'+@surname+'|Номер:'+@number,GetDate())


CREATE TRIGGER Product_After_Insert 
ON [dbo].[PRODUCT]
AFTER INSERT
AS
DECLARE 
@name nvarchar(64) = (select name from [inserted]),
@male_female nvarchar(1) = (select male_female from [inserted]),
@price money = (select price from [inserted])

INSERT into [dbo].[HistroryActions]
           ([description] 
           ,[date])
VALUES ('Добавление продукта | Имя:'+@name+' | Пол: '+@male_female+' | Стоимость: '+STR(@price),GetDate())


CREATE TRIGGER Client_InsteadOf_Delete
ON [dbo].[Client]
INSTEAD OF DELETE 
as 
DECLARE 
@id int = (select id_client from [deleted]),
@name nvarchar(64) = (select name_client from [deleted]),
@surname nvarchar(64) = (select surname_client from [deleted]),
@patronymic nvarchar(64) = (select patronymic_client from [deleted]),
@number nvarchar(20) = (select number_client from [deleted])

UPDATE [CLIENT]
SET IsDelete = 1
WHERE id_client =(SELECT id_client FROM deleted)

INSERT into [dbo].[HistroryActions] 
VALUES ('Удаление клиента |ID:'+STR(@id)+'|Имя:'+@name+'|Фамилия:'+@name+'|Отчество:'+@surname+'|Номер:'+@number,GetDate())


-------- INDEX --------
CREATE NONCLUSTERED INDEX index_product 
ON [PRODUCT] (name, male_female, price);