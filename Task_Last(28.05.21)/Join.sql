-- SELECT * FROM [PRODUCT]
-- SELECT * FROM [dbo].[PRODUCT_LIST]
-- SELECT * FROM [ORDER]
-- SELECT * FROM [CLIENT]
select id_order,sum(price_position) as price_position 
from PRODUCT_LIST where price_position between 10000 and 80000 
group by id_order

select id_order,sum(amount) as amount 
from PRODUCT_LIST 
group by id_order

insert into [CLIENT] ([name_client],[surname_client],[patronymic_client],[number_client],[IsDelete]) 
values ('name','surname','patron','45645654',0)

select max(price) as price 
from [dbo].[PRODUCT]

update [dbo].[PRODUCT] 
set name='name',male_female='Ц',price=546.00,IsDelete=0 
where [id_product] = 1075

delete from [PRODUCT] where [name]='иѓср'

-- JOIN --
select [PRODUCT_LIST].id_order,[CLIENT].name_client,sum(price_position) as price_position 
from PRODUCT_LIST,CLIENT,[dbo].[ORDER] 
where [ORDER].id_order=[PRODUCT_LIST].id_order AND [ORDER].id_client=[CLIENT].id_client
group by [PRODUCT_LIST].id_order,[CLIENT].name_client

select [CLIENT].name_client,sum([PRODUCT_LIST].[price_position]) as price_position,[ORDER].id_order
from [ORDER]
left join [PRODUCT_LIST] on [ORDER].id_order = [PRODUCT_LIST].id_order
left join [CLIENT] on [ORDER].id_client = [CLIENT].id_client
group by [CLIENT].name_client,[ORDER].id_order

SELECT * FROM [dbo].[PRODUCT_LIST]
