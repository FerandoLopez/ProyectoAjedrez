CREATE USER ajedrez
IDENTIFIED BY 'ajedrez';
GRANT ALL
ON ajedrez.*
TO ajedrez
WITH GRANT OPTION;