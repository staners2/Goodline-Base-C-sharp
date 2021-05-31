select * from [product_list]
select * from [product] 
select * from [client]
select * from [ORDER]

-- where DAY([ORDER].date) <= DATEPART(dd,GETDATE())-7

-- Товар не покупавшийся ни разу--
/*SELECT name,male_female,price 
FROM [PRODUCT]
WHERE [PRODUCT].id_product != 
ALL(SELECT id_product FROM [PRODUCT_LIST]) 

-- ВАРИАНТ 2 --
SELECT [PRODUCT].name,[PRODUCT].male_female,[PRODUCT].price
FROM product
--left join PRODUCT_LIST on [PRODUCT].id_product = [PRODUCT_LIST].id_product
EXCEPT 
SELECT [PRODUCT].name,[PRODUCT].male_female,[PRODUCT].price
FROM product_list
left join PRODUCT on [PRODUCT].id_product = [PRODUCT_LIST].id_product 

-- Товар не пользующийся спросом -- PRODUCT > 7 дней не покупался
SELECT DISTINCT [PRODUCT].name,[PRODUCT].male_female,[PRODUCT].price
from [PRODUCT]
left join [PRODUCT_LIST] on [PRODUCT_LIST].id_product=[PRODUCT].id_product
left join [ORDER] on [PRODUCT_LIST].id_order = [ORDER].id_order
where DATEDIFF(day, [ORDER].date, GETDATE()) > 7 

-- Сумма всех покупок клиентов --
SELECT name_client, surname_client, patronymic_client, sum(price_position) from PRODUCT_LIST,[ORDER]
left join [CLIENT] on [ORDER].id_client = [CLIENT].id_client
where [PRODUCT_LIST].id_order = [ORDER].id_order
group by name_client,surname_client,patronymic_client 

-- Наиболее продаваемый товар -- (TOP 5 товаров)
select [PRODUCT].name,[PRODUCT].male_female,sum(amount) as amount,ROUND(price,2) as price
from [PRODUCT_LIST]
left join [PRODUCT] on [PRODUCT_LIST].id_product=[PRODUCT].id_product
group by [PRODUCT].name,[PRODUCT].male_female,price
order by [amount] desc 
*/


-- TEST --
/*select [PRODUCT].id_product--,[PRODUCT].male_female,[PRODUCT].price
from [PRODUCT]
EXCEPT
select [PRODUCT_LIST].id_product
from [PRODUCT_LIST] */