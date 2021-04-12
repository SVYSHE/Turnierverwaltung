pragma foreign_keys=off;

drop table if exists fussballspieler;

pragma foreign_keys=on;

create table fussballspieler(
    id integer not null,
    name varchar(255) not null,
    rueckennummer integer not null   
);