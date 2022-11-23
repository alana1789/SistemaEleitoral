select * from eleicao
select ID_CANDIDATO,*, nome_candidato +'a' from candidato
select * from eleitor
select * from candidato

SELECT ID_ELEITOR,Nome,Titulo,Votou
from eleitor
where titulo Like %%



exec sp_executesql N'INSERT INTO Candidato(Numero, Nome) VALUES(@Numero, @Nome_candidato)',N'@Numero nvarchar(2),@Nome nvarchar(5)',@Numero=N'44',@Nome=N'ooooo'

                        