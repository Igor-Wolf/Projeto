select * from Games;

select * from AspNetUsers

-- Deletar elementos

DELETE FROM Games
WHERE Title = 'Elden Ring';


-- Adicionar Elementos.

INSERT INTO Games (Title, Genre, ReleaseDate, Rating, Description, Store, LinkImage)
VALUES 
    ('Dark Souls', 'Action RPG', '2011-09-22', 9.0, 'Dark Souls é um jogo de ação e RPG conhecido por seu desafio e atmosfera sombria.', 'Steam', 'https://images.igdb.com/igdb/image/upload/t_cover_big/co1x78.png'),
    ('Elden Ring', 'Action RPG', '2022-02-25', 9.5, 'Elden Ring é um RPG de ação de mundo aberto desenvolvido pela FromSoftware e publicado pela Bandai Namco Entertainment.', 'PlayStation Store', 'https://images.igdb.com/igdb/image/upload/t_cover_big/co4jni.png'),
    ('GTA V', 'Action-Adventure', '2013-09-17', 9.7, 'Grand Theft Auto V é um jogo eletrônico de ação-aventura desenvolvido pela Rockstar North e publicado pela Rockstar Games.', 'Xbox Live', 'https://images.igdb.com/igdb/image/upload/t_cover_big/co2lbd.png');

-- Adicionar Propriedades a elementos

UPDATE Games
SET LinkImage = 'https://images.igdb.com/igdb/image/upload/t_cover_big/co752b.png'
WHERE Title = 'Balatro';


INSERT INTO Games (Title, Genre, ReleaseDate, Rating, Description, Store, LinkImage)
VALUES 
    ('Hogwarts Legacy', 'Adventure, Role-playing (RPG)', '2023-02-10', 8.1, 'Hogwarts Legacy é um RPG de ação imersivo de mundo aberto ambientado no mundo apresentado nos livros de Harry Potter. Agora você pode controlar a ação e estar no centro da sua própria aventura no mundo da magia. Embarque em uma jornada por locais familiares e novos enquanto explora e descobre criaturas fantásticas, personaliza seu personagem e cria poções, domina a conjuração de feitiços, aprimora talentos e se torna o bruxo que deseja ser. Descubra a sensação de viver em Hogwarts enquanto faz aliados, batalha bruxos das trevas e, no final, decide o destino do mundo da magia. Seu legado é o que você faz dele.', 'Xbox One, PlayStation 5, Nintendo Switch, Xbox Series X|S, PC (Microsoft Windows), PlayStation 4', 'https://images.igdb.com/igdb/image/upload/t_cover_big/co2gn3.png');
