select product_name = p.name, category_name = c.name
from product p --Продукты
left join product_category pc on pc.product_id = p.id --Таблица для связи продуктов и категорий (многие ко многим)
left join category c  on c.id = pc.category_id --Категории