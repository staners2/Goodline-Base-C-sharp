-- 1 --
select DATENAME(MONTH, date) as '�����', count(MONTH(date))
from [order]
where MONTH(date) = 12
group by DATENAME(MONTH,date)

select * from [order]

-- 2 --
select DATENAME(day, date) as '����', count(day(date)) as '���-�� ����'
from [order]
where MONTH(date) = 12
group by DATENAME(day,date)

-- 3 --
select DATENAME(day, date) as '����', count(day(date)) as '���-�� ����'
from [order]
where MONTH(date) = 12
group by DATENAME(day,date)
having count(date) > 2

-- 4 -- 
-- ������� ������ � ������ � ��������� ����� � ���� ������ | realese left and right join
select name_client,[ORDER].date,[PRODUCT].name,amount,male_female,[order].id_order
from PRODUCT_LIST
right join [PRODUCT] on [PRODUCT_LIST].id_product = [PRODUCT].id_product
right join [ORDER] on [PRODUCT_LIST].id_order = [ORDER].id_order
left join [CLIENT] on [CLIENT].id_client = [ORDER].id_client

-- 5 -- | ������ � ������ ���� � ��� �����
select name_client, surname_client, [ORDER].id_order, [ORDER].date from CLIENT
right join [ORDER] on [ORDER].id_client = [CLIENT].id_client
where name_client = '����'
