

select bar.id , bar.descricao, cid.descricao as cidade 
from  bairro bar
inner join cidade cid on cid.id = bar.cidade



