SELECT * 
FROM Usuario
WHERE Ativo = 1
--id = 1 
--Email = 'nahaly@gmail.com'


INSERT INTO Usuario (Nome, Email)
  VALUES ('Pedro','pedro@gmail.com')

UPDATE Usuario SET Ativo = 0 WHERE Id = 2

