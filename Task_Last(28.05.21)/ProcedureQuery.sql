
create procedure ViewOrderInfo
as
select name_client, surname_client, patronymic_client, SUM(price_position) as price_position 
from PRODUCT_LIST,[ORDER]
left join[CLIENT] on[ORDER].id_client = [CLIENT].id_client
where [PRODUCT_LIST].id_order = [ORDER].id_order
group by name_client,surname_client,patronymic_client

execute ViewOrderInfo

create procedure GetSumOrder
@id int,
@price money out 
as
set @price = (
SELECT SUM([dbo].PRODUCT_LIST.price_position) as price_position 
FROM[dbo].PRODUCT_LIST 
WHERE [IsDelete] = 0 AND [id_order] = @id)
return @price

declare @result money
exec @result = GetSumOrder 1053, @price = @result output
select @result

create procedure FindClientId
@name nvarchar(50),
@surname nvarchar(50),
@patronymic nvarchar(50),
@number nvarchar(50),
@id int output
as
SELECT @id = [id_client] 
FROM [dbo].CLIENT WHERE 
[name_client]=@name AND [surname_client]=@surname 
AND [patronymic_client]=@patronymic AND [number_client]=@number

declare 
@id_ int
exec FindClientId 'Иван','Иванов','Иваныч','1(241)342-55-24', @id = @id_ output
select @id_
